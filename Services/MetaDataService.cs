using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

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
                bool isCreatable = entity.IsCustomizable?.Value == true && entity.IsIntersect == false && entity.OwnershipType == OwnershipTypes.UserOwned;

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

        public List<CRMField> GetEntityFields(CRMEntity entityRef, bool isEditable = false, bool isSearchable = false)
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
            List<AttributeMetadata> filteredAttributes = metadata.Attributes.ToList();

            if (isEditable)
            {
                filteredAttributes = GetEditableAttributes(metadata.Attributes.ToList());
            }
            else if(isSearchable)
            {
                filteredAttributes = filteredAttributes.Where(attr => attr.IsValidForAdvancedFind.Value == true).ToList();
            }

            foreach (AttributeMetadata attr in filteredAttributes)
            {
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

        public List<CRMView> GetEntityViews(string entityLogicalName)
        {
            List<CRMView> views = new List<CRMView>();
            if (_service == null || string.IsNullOrWhiteSpace(entityLogicalName))
            {
                return views;
            }

            QueryExpression queryExpression = new QueryExpression("savedquery")
            {
                ColumnSet = new ColumnSet("name", "fetchxml", "savedqueryid"),
                NoLock = true,
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("returnedtypecode", ConditionOperator.Equal, entityLogicalName),
                        new ConditionExpression("querytype", ConditionOperator.Equal, 0) // 0 = System View, 1 = User View
                    }
                }
            };

            EntityCollection results = _service.RetrieveMultiple(queryExpression);
            foreach (var entity in results.Entities)
            {
                CRMView view = new CRMView
                {
                    ID = entity.Id.ToString(),
                    Name = entity.GetAttributeValue<string>("name"),
                    FetchXML = entity.GetAttributeValue<string>("fetchxml")
                };
                views.Add(view);
            }
            
            return views;
        }

        private List<AttributeMetadata> GetEditableAttributes(List<AttributeMetadata> attributes)
        {
            return attributes.Where(attr => 
            attr.LogicalName != null &&
            attr.IsLogical == false &&
            attr.IsValidForCreate == true &&
            attr.IsValidForRead == true &&
            attr.IsValidODataAttribute == true &&
            attr.LogicalName != "timezoneruleversionnumber" &&
            attr.LogicalName != "utcconversiontimezonecode"
            ).ToList();
        }
    }
}