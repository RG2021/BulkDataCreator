using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Mockit.Common.ExpressionEngine;
using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mockit.Services
{
    public class DataGenService
    {
        private readonly IOrganizationService _service;
        public DataGenService(IOrganizationService service)
        {
            _service = service;
        }

        public ExecuteMultipleResponse CreateData(string entityLogicalName, List<GridRow> selectedFields, int recordCount)
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


    }
}