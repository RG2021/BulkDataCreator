using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using Mockit.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mockit.Services
{
    public class DataGenService
    {
        private readonly IOrganizationService _service;
        public DataGenService(IOrganizationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public ExecuteMultipleResponse CreateData(string entityLogicalName, List<GridRow> selectedFields, int recordCount)
        {
            if (string.IsNullOrWhiteSpace(entityLogicalName))
                throw new ArgumentException("Entity name is required.");

            if (selectedFields == null || selectedFields.Count == 0)
                throw new ArgumentException("No fields provided.");

            var multipleRequest = new ExecuteMultipleRequest
            {
                Settings = new ExecuteMultipleSettings
                {
                    ContinueOnError = false,
                    ReturnResponses = true
                },
                Requests = new OrganizationRequestCollection()
            };

            for (int i = 0; i < recordCount; i++)
            {
                Entity entity = new Entity(entityLogicalName);

                foreach (GridRow row in selectedFields)
                {
                    string fieldLogicalName = row.Field.LogicalName;
                    string fieldDataType = row.Field.DataType;
                    string fieldValue = row.Mock.Value;

                    object formattedValue = Helpers.FormatValueForCRM(fieldValue, fieldDataType);
                    entity[fieldLogicalName] = formattedValue;
                }

                multipleRequest.Requests.Add(new CreateRequest { Target = entity });
            }

            return (ExecuteMultipleResponse)_service.Execute(multipleRequest);
        }


    }
}