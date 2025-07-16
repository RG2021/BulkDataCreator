using Microsoft.Xrm.Sdk;
using System;

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
                    return parts.Length == 2 && Guid.TryParse(parts[1], out Guid id)? new EntityReference(parts[0], id) : null;

                default:
                    return rawValue;
            }
        }


    }
}