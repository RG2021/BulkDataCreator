using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;

namespace Mockit.Common.Constants
{
    public class Constants
    {
        public enum TokenType
        {
            SELECT,
            MULTISELECT,
            SEQUENCE,
            LOOKUP,
            DATE,
            NUMBER,
            BOGUS
        }
        public enum MockType
        {
            NONE = 0,
            AMOUNT = 758280012,
            BOOLEAN = 758280001,
            CUSTOM = 758280002,
            DATE = 758280003,
            EMAIL = 758280004,
            FULLADDRESS = 758280005,
            FULLNAME = 758280006,
            GUID = 758280007,
            LOOKUP = 758280008,
            NUMBER = 758280009,
            SELECT = 758280010,
            MULTISELECT = 758280014,
            SEQUENCE = 758280011,
            STRING = 758280013,
        }

        public static class DataType
        {
            public const string STRING = "StringType";
            public const string MEMO = "MemoType";
            public const string INTEGER = "IntegerType";
            public const string BIGINT = "BigIntType";
            public const string DECIMAL = "DecimalType";
            public const string DOUBLE = "DoubleType";
            public const string FLOAT = "FloatType";
            public const string MONEY = "MoneyType";
            public const string BOOLEAN = "BooleanType";
            public const string TWO_OPTIONS = "TwoOptionsType";
            public const string DATETIME = "DateTimeType";
            public const string PICKLIST = "PicklistType";
            public const string STATUS = "StatusType";
            public const string STATE = "StateType";
            public const string MULTISELECT_PICKLIST = "MultiSelectPicklistType";
            public const string LOOKUP = "LookupType";
            public const string CUSTOMER = "CustomerType";
            public const string OWNER = "OwnerType";
            public const string UNIQUEIDENTIFIER = "UniqueidentifierType";
        }

        public static readonly Dictionary<MockType, string> _HelperExpressions = new Dictionary<MockType, string> 
        {
            { MockType.BOOLEAN, "{{ RANDOM.BOOL }}" },
            { MockType.EMAIL, "{{ INTERNET.EMAIL }}" },
            { MockType.FULLADDRESS, "{{ ADDRESS.FULLADDRESS }}" },
            { MockType.FULLNAME, "{{ NAME.FULLNAME }}" },
            { MockType.GUID, "{{ RANDOM.GUID }}" },
            { MockType.NUMBER, "{{ MOCK.NUMBER(min, max, decimal) }}" },
            { MockType.AMOUNT, "{{ FINANCE.AMOUNT(min, max, decimal) }}" },
            { MockType.STRING , "{{ RANDOM.REPLACE(???####) }}" },
            { MockType.SELECT, "{{ MOCK.SELECT(option1, option2, etc) }}" },
            { MockType.MULTISELECT, "{{ MOCK.MULTISELECT(count, (option1, option2, etc)) }}" },
            { MockType.SEQUENCE, "{{ MOCK.SEQUENCE(fieldname, (value1, value2, etc)) }}" },
            { MockType.LOOKUP, "{{ MOCK.LOOKUP(fieldName, entityName, (GUID1, GUID2, etc)) }}" },
            { MockType.DATE, "{{ MOCK.DATE(min, max) }}" },
            
        };
    }
}