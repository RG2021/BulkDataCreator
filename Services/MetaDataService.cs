using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using Mockit.Models;
using Mockit.Common.Helpers;

namespace Mockit.Services
{
    public class MetadataService
    {
        private readonly IOrganizationService _service;

        public MetadataService(IOrganizationService service)
        {
            _service = service;
        }

        public List<CRMEntity> GetEntities(bool excludeSystemEntities = true)
        {
            List<CRMEntity> entities = new List<CRMEntity>();
            if (_service == null)
            {
                return entities; // Return empty list if service is not available
            }

            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Entity,
                RetrieveAsIfPublished = true
            };

            RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_service.Execute(request);

            EntityMetadata[] metadata = response.EntityMetadata;

            foreach (EntityMetadata entity in metadata)
            {
                //TODO: Add logic to include system entities if needed
                bool isCreatable = entity.IsCustomizable?.Value != false && !entity.IsIntersect.GetValueOrDefault(false) && entity.OwnershipType == OwnershipTypes.UserOwned && entity.IsManaged == false;

                if (!isCreatable && excludeSystemEntities)
                    continue;

                CRMEntity crmEntity = new CRMEntity
                {
                    ID = entity.MetadataId?.ToString() ?? string.Empty,
                    LogicalName = entity.LogicalName,
                    DisplayName = entity.DisplayName?.UserLocalizedLabel?.Label ?? entity.LogicalName,
                    PluralName = entity.DisplayCollectionName?.UserLocalizedLabel?.Label ?? "",
                };

                entities.Add(crmEntity);
            }

            entities.Sort((e1, e2) => string.Compare(e1.DisplayName, e2.DisplayName, StringComparison.OrdinalIgnoreCase));
            return entities;
        }

        public List<CRMField> GetFieldsForEntity(CRMEntity entityRef)
        {
            string entityLogicalName = entityRef?.LogicalName;
            List<CRMField> fields = new List<CRMField>();

            if (_service == null || string.IsNullOrWhiteSpace(entityLogicalName))
            {
                return fields; // Return empty list if service is not available or entity name is invalid
            }

            RetrieveEntityRequest request = new RetrieveEntityRequest
            {
                LogicalName = entityLogicalName,
                EntityFilters = EntityFilters.Attributes,
                RetrieveAsIfPublished = true
            };

            RetrieveEntityResponse response = (RetrieveEntityResponse)_service.Execute(request);
            EntityMetadata metadata = response.EntityMetadata;

            

            foreach (AttributeMetadata attr in metadata.Attributes)
            {
                if (attr.LogicalName == null || (attr.IsValidForCreate == false && attr.IsValidForUpdate == false))
                    continue;

                string displayName = attr.DisplayName?.UserLocalizedLabel?.Label ?? attr.LogicalName;

                CRMField field = new CRMField
                {
                    LogicalName = attr.LogicalName,
                    DisplayName = displayName,
                    DataType = attr.AttributeTypeName?.Value ?? attr.AttributeType?.ToString() ?? "Unknown",
                    IsCustom = attr.IsCustomAttribute == true,
                    Entity = entityRef,
                    Metadata = Helpers.GetMetadataForField(attr)
                };

                fields.Add(field);
            }

            fields.Sort((a, b) => string.Compare(a.DisplayName, b.DisplayName, StringComparison.OrdinalIgnoreCase));

            return fields;
        }
    }
}