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
            NONE = 758280000,
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
            AMOUNT = 758280012,
            STRING = 758280013,
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