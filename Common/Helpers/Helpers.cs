using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Mockit.Common.Constants;
using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Web.Services.Protocols;
using System.Windows.Documents;
using System.Windows.Navigation;
using static Mockit.Common.Constants.Constants;

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
                    if(int.TryParse(rawValue, out int intVal)) return intVal;
                    return rawValue;

                case "DoubleType":
                    if (double.TryParse(rawValue, out double dblVal)) return dblVal;
                    return rawValue;

                case "DecimalType":
                case "FloatType":
                case "MoneyType":
                    if (decimal.TryParse(rawValue, out decimal decVal)) return decVal;
                    return rawValue;

                case "BooleanType":
                case "TwoOptionsType":
                    return rawValue.Equals("true", StringComparison.OrdinalIgnoreCase) || rawValue == "1";

                case "DateTimeType":
                    if (DateTime.TryParse(rawValue, out DateTime dtVal)) return dtVal;
                    return rawValue;

                case "PicklistType":
                case "StatusType":
                case "StateType":
                    if(int.TryParse(rawValue, out int optVal))
                    {
                        return new OptionSetValue(optVal);
                    }
                    return rawValue;

                case "MultiSelectPicklistType":
                    var values = rawValue.Split(',').Select(v => v.Trim()).Where(v => int.TryParse(v, out _)).Select(v => new OptionSetValue(int.Parse(v))).ToArray();
                    return new OptionSetValueCollection(values);

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
            ExpressionEngine.ExpressionEngine expressionEngine = new ExpressionEngine.ExpressionEngine();
            List<EvaluationRecord> evaluationRecords = new List<EvaluationRecord>();

            for (int i = 0; i < recordCount; i++)
            {
                EvaluationRecord evaluationRecord = new EvaluationRecord();
                foreach (GridRow gridRow in gridRows)
                {
                    string logicalName = gridRow.Field.LogicalName;
                    string value = expressionEngine.Evaluate(gridRow.Mock.Expression, evaluationRecord);
                    evaluationRecord.SetFieldValue(logicalName, value);
                }

                if(evaluationRecord.GetFieldCount() == 0)
                    continue;

                evaluationRecords.Add(evaluationRecord);
            }
            return evaluationRecords;
        }

        public static string GetExpression(MockType type)
        {
            if(_HelperExpressions.TryGetValue(type, out string expression))
            {
                return expression;
            }
            return string.Empty;
        }

        public static List<MetadataItem> GetMetadataForField(AttributeMetadata attr)
        {
            List<MetadataItem> metadata = new List<MetadataItem>();

            // String
            if (attr is StringAttributeMetadata stringMeta)
            {
                if (stringMeta.MaxLength.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxLength", Value = stringMeta.MaxLength.Value.ToString() });
                if (stringMeta.FormatName != null)
                    metadata.Add(new MetadataItem { Name = "Format", Value = stringMeta.FormatName.Value });
            }

            // Memo
            else if (attr is MemoAttributeMetadata memoMeta)
            {
                if (memoMeta.MaxLength.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxLength", Value = memoMeta.MaxLength.Value.ToString() });
                if (memoMeta.FormatName != null)
                    metadata.Add(new MetadataItem { Name = "Format", Value = memoMeta.FormatName.Value });
            }

            // Integer
            else if (attr is IntegerAttributeMetadata intMeta)
            {
                if (intMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = intMeta.MinValue.Value.ToString() });
                if (intMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = intMeta.MaxValue.Value.ToString() });
            }

            // BigInt
            else if (attr is BigIntAttributeMetadata bigIntMeta)
            {
                if (bigIntMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = bigIntMeta.MinValue.Value.ToString() });
                if (bigIntMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = bigIntMeta.MaxValue.Value.ToString() });
            }

            // Decimal
            else if (attr is DecimalAttributeMetadata decMeta)
            {
                if (decMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = decMeta.MinValue.Value.ToString() });
                if (decMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = decMeta.MaxValue.Value.ToString() });
                if (decMeta.Precision.HasValue)
                    metadata.Add(new MetadataItem { Name = "Precision", Value = decMeta.Precision.Value.ToString() });
            }

            // Double
            else if (attr is DoubleAttributeMetadata dblMeta)
            {
                if (dblMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = dblMeta.MinValue.Value.ToString() });
                if (dblMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = dblMeta.MaxValue.Value.ToString() });
            }

            // Money
            else if (attr is MoneyAttributeMetadata moneyMeta)
            {
                if (moneyMeta.MinValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MinValue", Value = moneyMeta.MinValue.Value.ToString() });
                if (moneyMeta.MaxValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "MaxValue", Value = moneyMeta.MaxValue.Value.ToString() });
                if (moneyMeta.Precision.HasValue)
                    metadata.Add(new MetadataItem { Name = "Precision", Value = moneyMeta.Precision.Value.ToString() });
            }

            // Boolean
            else if (attr is BooleanAttributeMetadata boolMeta)
            {
                metadata.Add(new MetadataItem { Name = "DefaultValue", Value = boolMeta.DefaultValue.HasValue ? boolMeta.DefaultValue.Value.ToString() : "false" });
                if (boolMeta.OptionSet != null)
                {
                    var options = new List<string>();
                    if (boolMeta.OptionSet.TrueOption != null)
                    {
                        var trueLabel = boolMeta.OptionSet.TrueOption.Label?.UserLocalizedLabel?.Label ?? boolMeta.OptionSet.TrueOption.Value.ToString();
                        options.Add($"{trueLabel} ({boolMeta.OptionSet.TrueOption.Value})");
                    }
                    if (boolMeta.OptionSet.FalseOption != null)
                    {
                        var falseLabel = boolMeta.OptionSet.FalseOption.Label?.UserLocalizedLabel?.Label ?? boolMeta.OptionSet.FalseOption.Value.ToString();
                        options.Add($"{falseLabel} ({boolMeta.OptionSet.FalseOption.Value})");
                    }
                    metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
                }
            }

            // Picklist
            else if (attr is PicklistAttributeMetadata picklistMeta)
            {
                var options = picklistMeta.OptionSet.Options.Select(opt => $"{opt.Label?.UserLocalizedLabel?.Label ?? opt.Value.ToString()} ({opt.Value})");
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
                if (picklistMeta.DefaultFormValue.HasValue)
                    metadata.Add(new MetadataItem { Name = "DefaultValue", Value = picklistMeta.DefaultFormValue.Value.ToString() });
            }

            // MultiSelectPicklist
            else if (attr is MultiSelectPicklistAttributeMetadata multiSelectMeta)
            {
                var options = multiSelectMeta.OptionSet.Options
                    .Select(opt => $"{opt.Label?.UserLocalizedLabel?.Label ?? opt.Value.ToString()} ({opt.Value})");
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }

            // Status
            else if (attr is StatusAttributeMetadata statusMeta)
            {
                var options = statusMeta.OptionSet.Options
                    .Select(opt => $"{opt.Label?.UserLocalizedLabel?.Label ?? opt.Value.ToString()} ({opt.Value})");
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }

            // State
            else if (attr is StateAttributeMetadata stateMeta)
            {
                var options = stateMeta.OptionSet.Options.Select(opt => $"{opt.Label?.UserLocalizedLabel?.Label ?? opt.Value.ToString()} ({opt.Value})");
                metadata.Add(new MetadataItem { Name = "Options", Value = string.Join(", ", options) });
            }

            // Lookup
            else if (attr is LookupAttributeMetadata lookupMeta)
            {
                if (lookupMeta.Targets != null && lookupMeta.Targets.Length > 0)
                {
                    string targets = string.Join(", ", lookupMeta.Targets);
                    metadata.Add(new MetadataItem { Name = "Lookup Entities", Value = targets });
                }
            }

            // DateTime
            else if (attr is DateTimeAttributeMetadata dateMeta)
            {
                if (dateMeta.Format != null)
                    metadata.Add(new MetadataItem { Name = "Format", Value = dateMeta.Format.Value.ToString() });
                if (dateMeta.ImeMode.HasValue)
                    metadata.Add(new MetadataItem { Name = "ImeMode", Value = dateMeta.ImeMode.Value.ToString() });
            }

            // Uniqueidentifier
            else if (attr is UniqueIdentifierAttributeMetadata guidMeta)
            {
                metadata.Add(new MetadataItem { Name = "Type", Value = "GUID" });
            }

            return metadata;
        }

        public static Mock GetSuggestedMockForField(CRMField field)
        {
            if (field == null || string.IsNullOrEmpty(field.LogicalName))
                return null;

            Mock mock = new Mock();

            string crmFieldType = field.DataType;

            string expression = string.Empty;
            MockType mockType = MockType.NONE;
            bool useCustom = false;

            switch (crmFieldType)
            {
                case "StringType":
                case "MemoType":
                {
                    expression = GetExpression(MockType.STRING);
                    mockType = MockType.STRING;
                    break;
                }

                case "IntegerType":
                case "BigIntType":
                case "DecimalType":
                case "DoubleType":
                case "FloatType":
                case "MoneyType":
                    {
                    double min = field.Metadata.Where(m => m.Name == "MinValue").Select(m => double.TryParse(m.Value, out double minVal) ? minVal : 0).FirstOrDefault();
                    double max = field.Metadata.Where(m => m.Name == "MaxValue").Select(m => double.TryParse(m.Value, out double maxVal) ? maxVal : 100).FirstOrDefault();
                    int precision = field.Metadata.Where(m => m.Name == "Precision").Select(m => int.TryParse(m.Value, out int precisionVal) ? precisionVal : 0).FirstOrDefault();

                    expression = GetExpression(MockType.NUMBER).Replace("min", min.ToString()).Replace("max", max.ToString()).Replace("decimal", precision.ToString());
                    mockType = MockType.NUMBER;
                    break;
                }

                //case "MoneyType":
                //{
                //    double min = field.Metadata.Where(m => m.Name == "MinValue").Select(m => double.TryParse(m.Value, out double minVal) ? minVal : 0).FirstOrDefault();
                //    double max = field.Metadata.Where(m => m.Name == "MaxValue").Select(m => double.TryParse(m.Value, out double maxVal) ? maxVal : 100).FirstOrDefault();
                //    int precision = field.Metadata.Where(m => m.Name == "Precision").Select(m => int.TryParse(m.Value, out int precisionVal) ? precisionVal : 0).FirstOrDefault();

                //    expression = GetExpression(MockType.AMOUNT).Replace("min", min.ToString()).Replace("max", max.ToString()).Replace("decimal", precision.ToString());
                //    mockType = MockType.AMOUNT;
                //    break;
                //}

                case "BooleanType":
                case "TwoOptionsType":
                {
                    expression = GetExpression(MockType.BOOLEAN);
                    mockType = MockType.BOOLEAN;
                    break;
                }

                case "DateTimeType":
                {
                    DateTime minDate = new DateTime(2000, 1, 1);
                    DateTime maxDate = DateTime.UtcNow;
                    expression = GetExpression(MockType.DATE).Replace("min", minDate.ToString("yyyy-MM-dd")).Replace("max", maxDate.ToString("yyyy-MM-dd"));
                    mockType = MockType.DATE;
                    break;
                }

                case "PicklistType":
                case "StatusType":
                case "StateType":
                {
                    var options = field.Metadata.Where(m => m.Name == "Options").Select(m => m.Value ?? "").FirstOrDefault();
                    var matches = Regex.Matches(options, @"\((\d+)\)");

                    if (matches.Count > 0)
                    {
                        var optionsList = string.Join(", ", matches.Cast<Match>().Select(m => m.Groups[1].Value));
                        expression = GetExpression(MockType.SELECT).Replace("option1, option2, etc", optionsList);
                        mockType = MockType.SELECT;
                    }
                    break;
                }

                case "MultiSelectPicklistType":
                {
                    var options = field.Metadata.Where(m => m.Name == "Options").Select(m => m.Value ?? "").FirstOrDefault();
                    var matches = Regex.Matches(options, @"\((\d+)\)");
                    if (matches.Count > 0)
                    {
                        var optionsList = string.Join(", ", matches.Cast<Match>().Select(m => m.Groups[1].Value));
                        expression = GetExpression(MockType.MULTISELECT).Replace("count", "1").Replace("option1, option2, etc", optionsList);
                        mockType = MockType.SELECT;
                    }
                    break;
                }

                case "LookupType":
                case "CustomerType":
                case "OwnerType":
                {
                    var targets = field.Metadata.Where(m => m.Name == "Lookup Entities").Select(m => m.Value ?? "").FirstOrDefault();
                    if (!string.IsNullOrEmpty(targets))
                    {
                        var targetList = targets.Split(',').Select(t => t.Trim()).ToList();
                        expression = GetExpression(MockType.LOOKUP).Replace("fieldName", field.LogicalName).Replace("entityName", targetList.FirstOrDefault());
                        mockType = MockType.LOOKUP;
                    }
                    break;
                }

                case "UniqueidentifierType":
                {
                    expression = GetExpression(MockType.GUID);
                    mockType = MockType.GUID;
                    break;
                }

                default:
                {
                    expression = GetExpression(MockType.CUSTOM);
                    mockType = MockType.CUSTOM;
                    useCustom = true;
                    break;
                }
            }

            mock.Expression = expression;
            mock.MockType = mockType;
            mock.UseCustom = useCustom;
            return mock;
        }
    }
}