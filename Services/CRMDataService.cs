using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;

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

            const int batchSize = 250;
            List<EvaluationRecord> evaluatedRecords = Helpers.GetEvaluationRecords(selectedFields, recordCount);
            ExecuteMultipleResponse lastResponse = new ExecuteMultipleResponse();


            for (int i = 0; i < evaluatedRecords.Count; i += batchSize)
            {
                var multipleRequest = new ExecuteMultipleRequest
                {
                    Settings = new ExecuteMultipleSettings
                    {
                        ContinueOnError = false,
                        ReturnResponses = true
                    },
                    Requests = new OrganizationRequestCollection()
                };

                int currentBatchSize = Math.Min(batchSize, evaluatedRecords.Count - i);

                for (int j = 0; j < currentBatchSize; j++)
                {
                    EvaluationRecord record = evaluatedRecords[i + j];
                    Entity entity = new Entity(entityLogicalName);

                    foreach (GridRow field in selectedFields)
                    {
                        string fieldLogicalName = field.Field.LogicalName;
                        string fieldDataType = field.Field.DataType;
                        string fieldValue = record.GetFieldValue(fieldLogicalName);
                        object formattedValue = Helpers.FormatValueForCRM(fieldValue, fieldDataType);
                        entity[fieldLogicalName] = formattedValue;
                    }

                    multipleRequest.Requests.Add(new CreateRequest { Target = entity });
                }

                lastResponse = (ExecuteMultipleResponse)_service.Execute(multipleRequest);
            }

            return lastResponse;
        }

        public EntityCollection GetRecordsFromID(string entityLogicalName, List<Guid> createdRecordsIds)
        {
            int batchSize = 1000;
            EntityCollection results = new EntityCollection();

            if (string.IsNullOrWhiteSpace(entityLogicalName))
            {
                throw new ArgumentException("Entity logical name cannot be null or empty.");
            }
            if (createdRecordsIds == null || createdRecordsIds.Count == 0)
            {
                throw new ArgumentException("Created record IDs must be greater than zero.");
            }
            for(int i = 0; i < createdRecordsIds.Count; i += batchSize)
            {
                int currentBatchSize = Math.Min(batchSize, createdRecordsIds.Count - i);
                List<Guid> batchIds = createdRecordsIds.GetRange(i, currentBatchSize);

                QueryExpression query = new QueryExpression
                {
                    EntityName = entityLogicalName,
                    ColumnSet = new ColumnSet(true),
                    Criteria = new FilterExpression
                    {
                        FilterOperator = LogicalOperator.And,
                        Conditions =
                        {
                            new ConditionExpression( entityLogicalName + "id", ConditionOperator.In, batchIds.ToArray())
                        }
                    }
                };

                EntityCollection batchResults = _service.RetrieveMultiple(query);
                results.Entities.AddRange(batchResults.Entities);
            }
            
            return results;
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