using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Linq;

public class NumberToken : BaseToken
{
    public override string Name => "Number";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "[Missing arguments]";

        string[] parts = args.Split(',').Select(p => p.Trim()).ToArray();
        if (parts.Length < 2)
            return "[Invalid format. Use: NUMBER(min, max, [decimal])]";

        if (!double.TryParse(parts[0], out double min) || !double.TryParse(parts[1], out double max))
            return "[Invalid Min/Max values]";

        int decimalPlaces = 0;
        if (parts.Length >= 3 && !int.TryParse(parts[2], out decimalPlaces))
            return "[Invalid DecimalPlaces]";

        double randomValue = Faker.Random.Double(min, max);

        //if (decimalPlaces <= 0)
        //    return ((double)randomValue).ToString();

        return Math.Round(randomValue, decimalPlaces, MidpointRounding.AwayFromZero).ToString();
    }
}
