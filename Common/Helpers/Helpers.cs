using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Common.Helpers
{
    public static class Helpers
    {
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
            if (Enum.TryParse(type.ToString(), out TokenType tokenType))
            {
                if (TokensRegistry.RegisterTokens().TryGetValue(tokenType, out var token))
                {
                    return token.Expression;
                }
            }
            return string.Empty;
        }

        public static List<MetadataItem> GetMetadataForField(AttributeMetadata attr)
        {

            List<MetadataItem> metadata = new List<MetadataItem>();

            if (attr is StringAttributeMetadata stringMeta)
            {
                if (stringMeta.MaxLength.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxLength", Value = stringMeta.MaxLength.Value.ToString() });
            }
            else if (attr is IntegerAttributeMetadata intMeta)
            {
                if (intMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = intMeta.MinValue.Value.ToString() });
                if (intMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = intMeta.MaxValue.Value.ToString() });
            }

            else if (attr is DecimalAttributeMetadata decMeta)
            {
                if (decMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = decMeta.MinValue.Value.ToString() });
                if (decMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = decMeta.MaxValue.Value.ToString() });
                if (decMeta.Precision.HasValue)
                    metadata.Add(new MetadataItem { Name = "Precision", Value = decMeta.Precision.Value.ToString() });
            }

            else if (attr is DoubleAttributeMetadata dblMeta)
            {
                if (dblMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = dblMeta.MinValue.Value.ToString() });
                if (dblMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = dblMeta.MaxValue.Value.ToString() });
            }

            else if (attr is MoneyAttributeMetadata moneyMeta)
            {
                if (moneyMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = moneyMeta.MinValue.Value.ToString() });
                if (moneyMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = moneyMeta.MaxValue.Value.ToString() });
            }

            else if (attr is PicklistAttributeMetadata picklistMeta)
            {
                var options = new List<string>();
                foreach (var option in picklistMeta.OptionSet.Options)
                {
                    string name = option.Label?.UserLocalizedLabel?.Label ?? option.Value.ToString();
                    options.Add($"{name}({option.Value})");
                }
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }

            else if (attr is BooleanAttributeMetadata boolMeta)
            {
                metadata.Add(new MetadataItem { Name = "DefaultValue", Value = boolMeta.DefaultValue.HasValue ? boolMeta.DefaultValue.Value.ToString() : "false" });
            }

            else if (attr is MultiSelectPicklistAttributeMetadata multiSelectMeta)
            {
                var options = new List<string>();
                foreach (var option in multiSelectMeta.OptionSet.Options)
                {
                    string name = option.Label?.UserLocalizedLabel?.Label ?? option.Value.ToString();
                    options.Add($"{name}({option.Value})");
                }
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }

            else if (attr is LookupAttributeMetadata lookupMeta)
            {
                if (lookupMeta.Targets != null && lookupMeta.Targets.Length > 0)
                {
                    string targets = string.Join(", ", lookupMeta.Targets);
                    metadata.Add(new MetadataItem { Name = "Lookup Entity Names", Value = $"{targets}" });
                }
            }
            else if (attr is StatusAttributeMetadata statusMeta)
            {
                var options = new List<string>();
                foreach (var option in statusMeta.OptionSet.Options)
                {
                    string name = option.Label?.UserLocalizedLabel?.Label ?? option.Value.ToString();
                    options.Add($"{name}({option.Value})");
                }
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }
            return metadata;
        }
    }
}