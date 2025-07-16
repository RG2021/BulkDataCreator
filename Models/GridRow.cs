namespace Mockit.Models
{
    public class GridRow
    {
        public CRMField Field { get; set; }
        public Mock Mock {  get; set; }
        public string FieldName => Field?.DisplayName;
        public string FieldType => Field?.DataType;
        public string MockType => Mock?.MockType.ToString();
        public string MockValue => Mock?.Value;

    }
}