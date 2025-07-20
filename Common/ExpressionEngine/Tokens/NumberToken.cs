using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Linq;

public class NumberToken : BaseToken
{
    public override string Name => "Number";
    public override string Expression => "{{ NUMBER(min, max, [decimal]) }}";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "[Missing arguments]";

        string[] parts = args.Split(',').Select(p => p.Trim()).ToArray();
        if (parts.Length < 2)
            return "[Invalid format. Use: NUMBER(min, max, [decimal])]";

        if (!int.TryParse(parts[0], out int min) || !int.TryParse(parts[1], out int max))
            return "[Invalid Min/Max values]";

        int decimalPlaces = 0;
        if (parts.Length >= 3 && !int.TryParse(parts[2], out decimalPlaces))
            return "[Invalid DecimalPlaces]";

        decimal randomValue = Faker.Random.Decimal(min, max);

        if (decimalPlaces <= 0)
            return ((int)randomValue).ToString();

        return Math.Round(randomValue, decimalPlaces, MidpointRounding.AwayFromZero).ToString();
    }
}
