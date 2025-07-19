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
            FULLADDRESS = 758280004,
            BOOLEAN = 758280005,
            GUID = 758280006,
            LOOKUP = 758280007,
            SEQUENCE = 758280008,
            DATE = 758280009,
            NUMBER = 758280010,
            SELECT = 758280011
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
            DATE,
            BOOLEAN,
            GUID
        }
    }
}