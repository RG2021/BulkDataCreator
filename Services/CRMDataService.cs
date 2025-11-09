using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.WebServiceClient;
using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Web.Services.Description;
using XrmToolBox.Extensibility;

namespace Mockit.Services
{
    public class CRMDataService
    {
        private readonly IOrganizationService _service;
        public CRMDataService(IOrganizationService service)
        {
            _service = service;
        }
        public ExecuteMultipleResponse CreateRecords(string entityLogicalName, List<GridRow> selectedFields, int recordCount)
        {

            if (string.IsNullOrWhiteSpace(entityLogicalName))
            {
                throw new ArgumentException("Entity logical name cannot be null or empty.");
            }
               
            if (selectedFields == null || selectedFields.Count == 0)
            {
                throw new ArgumentException("Selected fields must be greater than zero.");
            }

            if (recordCount <= 0)
            {
                throw new ArgumentOutOfRangeException("Record count must be greater than zero.");
            }

            List<EvaluationRecord> evaluatedRecords = Helpers.GetEvaluationRecords(selectedFields, recordCount);

            ExecuteMultipleRequest multipleRequest = new ExecuteMultipleRequest
            {
                Settings = new ExecuteMultipleSettings
                {
                    ContinueOnError = false,
                    ReturnResponses = true
                },
                Requests = new OrganizationRequestCollection()
            };

            foreach (EvaluationRecord evaluatedRecord in evaluatedRecords) 
            {
                Entity entity = new Entity(entityLogicalName);
                foreach (GridRow field in selectedFields)
                {
                    string fieldLogicalName = field.Field.LogicalName;
                    string fieldDataType = field.Field.DataType;

                    string fieldValue = evaluatedRecord.GetFieldValue(fieldLogicalName);
                    object formattedValue = Helpers.FormatValueForCRM(fieldValue, fieldDataType);

                    entity[fieldLogicalName] = formattedValue;
                }

                multipleRequest.Requests.Add(new CreateRequest { Target = entity });
            }

            ExecuteMultipleResponse executeMultipleResponse = (ExecuteMultipleResponse)_service.Execute(multipleRequest);
            return executeMultipleResponse;
        }

        public EntityCollection GetRecordsFromID(string entityLogicalName, List<Guid> createdRecordsIds)
        {
            if (string.IsNullOrWhiteSpace(entityLogicalName))
            {
                throw new ArgumentException("Entity logical name cannot be null or empty.");
            }
            if (createdRecordsIds == null || createdRecordsIds.Count == 0)
            {
                throw new ArgumentException("Created record IDs must be greater than zero.");
            }

            QueryExpression query = new QueryExpression
            {
                EntityName = entityLogicalName,
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    FilterOperator = LogicalOperator.And,
                    Conditions =
                        {
                            new ConditionExpression( entityLogicalName + "id", ConditionOperator.In, createdRecordsIds.ToArray())
                        }
                }
            };

            EntityCollection batchResults = _service.RetrieveMultiple(query);
            return batchResults;
        }

        public (EntityCollection, bool) GetRecordsFromView(string fetchXML, int pageNumber, string searchField, string searchText)
        {
            EntityCollection results = new EntityCollection();
            bool moreRecords = false;

            if (_service == null || string.IsNullOrWhiteSpace(fetchXML))
            {
                return (results, moreRecords);
            }

            fetchXML = Helpers.AddPageAndCountAttributes(fetchXML, pageNumber, 50);

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string searchCondition = $"<condition attribute='{searchField}' operator='like' value='%{searchText}%' />";
                fetchXML = Helpers.InsertConditionIntoFetchXML(fetchXML, searchCondition);
            }

            FetchExpression fetchExpression = new FetchExpression(fetchXML);
            results = _service.RetrieveMultiple(fetchExpression);
            moreRecords = results.MoreRecords;

            return (results, moreRecords);
        }
    }
}