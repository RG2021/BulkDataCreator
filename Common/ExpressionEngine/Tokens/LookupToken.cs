using Bogus;
using System;
using System.Collections.Generic;

public class LookupToken : BaseToken
{
    public override string Name => "Lookup";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "[Missing arguments. Use: LOOKUP(entity,(GUID1,GUID2,…))]";

        int commaIndex = args.IndexOf(',');
        if (commaIndex < 0)
            return "[Invalid format. Use: LOOKUP(entity,(GUID1,GUID2,…))]";

        string entityLogicalName = args.Substring(0, commaIndex).Trim();
        string guidPart = args.Substring(commaIndex + 1).Trim();

        guidPart = guidPart.Trim('(', ')', ' ');

        string[] rawGuids = guidPart.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);

        List<Guid> guidList = new List<Guid>();
        foreach (string raw in rawGuids)
        {
            if (Guid.TryParse(raw.Trim(), out Guid parsed))
                guidList.Add(parsed);
        }

        if (string.IsNullOrWhiteSpace(entityLogicalName) || guidList.Count == 0)
            return "[Invalid entity or GUID list]";

        Guid chosen = Faker.PickRandom<Guid>(guidList);

        return $"{entityLogicalName}:{chosen}";
    }
}
