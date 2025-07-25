using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;

namespace Mockit.Common.Enums
{
    public class Constants
    {
        public enum TokenType
        {
            SELECT,
            SEQUENCE,
            LOOKUP,
            DATE,
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
            SEQUENCE = 758280011,
        }

        public static readonly Dictionary<MockType, string> _HelperExpressions = new Dictionary<MockType, string> 
        {
            { MockType.BOOLEAN, "{{ RANDOM.BOOL }}" },
            { MockType.EMAIL, "{{ INTERNET.EMAIL }}" },
            { MockType.FULLADDRESS, "{{ ADDRESS.FULLADDRESS }}" },
            { MockType.FULLNAME, "{{ NAME.FULLNAME }}" },
            { MockType.GUID, "{{ RANDOM.GUID }}" },
            { MockType.NUMBER, "{{ RANDOM.NUMBER(min, max) }}" },
            { MockType.SELECT, "{{ MOCK.SELECT(option1, option2, ...) }}" },
            { MockType.SEQUENCE, "{{ MOCK.SEQUENCE(fieldName, min, max) }}" },
            { MockType.LOOKUP, "{{ MOCK.LOOKUP(fieldName, entityName, (GUID1, GUID2, ...)) }}" },
            { MockType.DATE, "{{ MOCK.DATE(minDate, maxDate) }}" },
        };
    }
}