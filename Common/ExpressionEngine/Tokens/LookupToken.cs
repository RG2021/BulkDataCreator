using Bogus;
using System;
using System.Collections.Generic;

public class LookupToken : BaseToken
{
    private readonly object _lock = new object();
    public override string Name => "Lookup";
    public override string Expression => "{{ LOOKUP(fieldName, entityName, (GUID1, GUID2, …)) }}";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "[Missing arguments. Use: LOOKUP(fieldName, entityName, (GUID1, GUID2, …))]";

        int keyIndex = args.IndexOf(',');
        if (keyIndex < 0)
            return "[Invalid format. Use: LOOKUP(fieldName, entityName, (GUID1, GUID2, …))]";

        int entityIndex = args.IndexOf(',', keyIndex + 1);
        if (entityIndex < 0)
            return "[Invalid format. Use: LOOKUP(fieldName, entityName, (GUID1, GUID2, …))]";

        string keyPart = args.Substring(0, keyIndex).Trim();
        string entityPart = args.Substring(keyIndex + 1, entityIndex - keyIndex - 1).Trim();
        string guidPart = args.Substring(entityIndex + 1).Trim();

        guidPart = guidPart.Trim('(', ')', ' ');

        string[] rawGuids = guidPart.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);

        List<Guid> guidList = new List<Guid>();
        foreach (string raw in rawGuids)
        {
            if (Guid.TryParse(raw.Trim(), out Guid parsed))
                guidList.Add(parsed);
        }

        if (string.IsNullOrWhiteSpace(entityPart) || guidList.Count == 0)
            return "[Invalid entity or GUID list]";

        int index;
        lock (_lock)
        {
            if (!_fieldSequenceCounters.TryGetValue(keyPart, out index) || index >= guidList.Count)
            {
                index = 0;
            }
            _fieldSequenceCounters[keyPart] = index + 1;

            Guid chosen = guidList[index];
            return $"{entityPart}:{chosen}";
        }
        
    }
}
