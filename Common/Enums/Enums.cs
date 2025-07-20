namespace Mockit.Common.Enums
{
    public class Enums
    {
        public enum TokenType
        {
            FULLNAME,
            EMAIL,
            FULLADDRESS,
            NUMBER,
            SELECT,
            SEQUENCE,
            LOOKUP,
            DATE,
            BOOLEAN,
            GUID
        }
        public enum MockType
        {
            NONE = 0,
            CUSTOM = 1,
            FULLNAME = TokenType.FULLNAME,
            EMAIL = TokenType.EMAIL,
            FULLADDRESS = TokenType.FULLADDRESS,
            BOOLEAN = TokenType.BOOLEAN,
            GUID = TokenType.GUID,
            LOOKUP = TokenType.LOOKUP,
            SEQUENCE = TokenType.SEQUENCE,
            DATE = TokenType.DATE,
            NUMBER = TokenType.NUMBER,
            SELECT = TokenType.SELECT
        }
    }
}