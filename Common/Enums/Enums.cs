namespace Mockit.Common.Enums
{
    public class Enums
    {
        public enum MockType
        {
            NONE = 0,
            CUSTOM = 1,
            FULLNAME = 758280002,
            EMAIL = 758280003,
            FULLADDRESS = 758280004
        }

        public enum TokenType
        {
            FULLNAME,
            EMAIL,
            FULLADDRESS,
            NUMBER,
            SELECT,
            SEQUENCE,
            LOOKUP,
            DATE
        }
    }
}