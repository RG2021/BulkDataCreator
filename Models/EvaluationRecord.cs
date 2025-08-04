using System.Collections.Generic;

namespace Mockit.Models
{
    public class EvaluationRecord
    {
        public Dictionary<string, string> Fields { get; private set; } = new Dictionary<string, string>();

        public void SetFieldValue(string fieldName, string value)
        {
            Fields[fieldName] = value;
        }

        public string GetFieldValue(string fieldName)
        {
            return Fields.TryGetValue(fieldName, out var value) ? value : null;
        }

        public int GetFieldCount()
        {
            return Fields.Count;
        }
    }
}