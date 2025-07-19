using Microsoft.Xrm.Sdk;
using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Windows.Documents;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Common.Helpers
{
    public static class Helpers
    {
        private static readonly Dictionary<MockType, string> _expressions = new Dictionary<MockType, string>
        {
            { MockType.NONE, "" },
            { MockType.FULLNAME, "{{ FULLNAME }}" },
            { MockType.EMAIL, "{{ EMAIL }}" },
            { MockType.FULLADDRESS, "{{ FULLADDRESS }}" },
            { MockType.BOOLEAN, "{{ BOOLEAN }}" },
            { MockType.GUID, "{{ GUID }}" },
            { MockType.LOOKUP, "{{ LOOKUP(fieldName, entityName, (GUID1, GUID2, ...) }}" },
            { MockType.SEQUENCE, "{{ SEQUENCE(fieldName, minValue, maxValue) }}" },
            { MockType.DATE, "{{ DATE(minDate, maxDate) }}" },
            { MockType.NUMBER, "{{ NUMBER(min, max, decimal) }}" },
            { MockType.SELECT, "{{ SELECT(option1, option2, ... ) }}" }
        };

        public static object FormatValueForCRM(string rawValue, string crmDataType)
        {
            switch (crmDataType)
            {
                case "StringType":
                case "MemoType":
                    return rawValue;

                case "IntegerType":
                case "BigIntType":
                    return int.TryParse(rawValue, out int intVal) ? intVal : 0;

                case "DecimalType":
                case "DoubleType":
                case "FloatType":
                    return decimal.TryParse(rawValue, out decimal decVal) ? decVal : 0;

                case "BooleanType":
                case "TwoOptionsType":
                    return rawValue.Equals("true", StringComparison.OrdinalIgnoreCase) || rawValue == "1";

                case "DateTimeType":
                    return DateTime.TryParse(rawValue, out DateTime dtVal) ? dtVal : DateTime.UtcNow;

                case "PicklistType":
                case "StatusType":
                case "StateType":
                    return new OptionSetValue(int.TryParse(rawValue, out int optVal) ? optVal : 0);

                case "LookupType":
                case "CustomerType":
                case "OwnerType":
                    var parts = rawValue.Split(':');
                    return parts.Length == 2 && Guid.TryParse(parts[1], out Guid id) ? new EntityReference(parts[0], id) : null;

                default:
                    return rawValue;
            }
        }

        public static List<EvaluationRecord> GetEvaluationRecords(List<GridRow> gridRows, int recordCount)
        {
            List<EvaluationRecord> evaluationRecords = new List<EvaluationRecord>();
            for (int i = 0; i < recordCount; i++)
            {
                EvaluationRecord evaluationRecord = new EvaluationRecord();
                foreach (GridRow gridRow in gridRows)
                {
                    string logicalName = gridRow.Field.LogicalName;
                    string value = ExpressionEngine.ExpressionEngine.Evaluate(gridRow.Mock.Expression, evaluationRecord);
                    evaluationRecord.SetFieldValue(logicalName, value);
                }

                evaluationRecords.Add(evaluationRecord);
            }
            return evaluationRecords;
        }

        public static string GetExpression(MockType type)
        {
            return _expressions.ContainsKey(type) ? _expressions[type] : string.Empty;
        }
    }
}