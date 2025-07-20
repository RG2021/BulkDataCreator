using Bogus;
using System;
using System.Linq;

public class SelectToken : BaseToken
{
    public override string Name => "SELECT";
    public override string Expression => "{{ SELECT(option1, option2, ...) }}";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return string.Empty;

        string[] parts = args
            .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
            .Select(p => p.Trim())
            .ToArray();

        if (parts.Length == 0)
            return string.Empty;

        int index = Faker.Random.Int(0, parts.Length - 1);
        return parts[index];
    }
}