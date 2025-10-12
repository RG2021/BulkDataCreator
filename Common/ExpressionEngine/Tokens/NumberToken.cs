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

        if (!decimal.TryParse(parts[0], out decimal min) || !decimal.TryParse(parts[1], out decimal max))
            return "[Invalid Min/Max values]";

        int decimalPlaces = 0;
        if (parts.Length >= 3 && !int.TryParse(parts[2], out decimalPlaces))
            return "[Invalid DecimalPlaces]";

        if (min > max)
            return "[Min cannot be greater than Max]";

        double randomDoubleFactor = Faker.Random.Double(0, 1);

        decimal absMaxBound = Math.Max(Math.Abs(min), Math.Abs(max));
        double weightedMagnitudeFactor = Math.Pow(Faker.Random.Double(0, 1), 3);

        decimal range = max - min;
        decimal negativeRange = (min < 0) ? Math.Abs(min) : 0;

        bool isNegative = (randomDoubleFactor < (double)negativeRange / (double)range);
        decimal magnitude = absMaxBound * (decimal)weightedMagnitudeFactor;

        decimal randomValue = isNegative ? -magnitude : magnitude;
        randomValue = Math.Max(min, Math.Min(max, randomValue));

        decimal result = Math.Round(randomValue, decimalPlaces);

        if (result < min) result = min;
        if (result > max) result = max;

        return result.ToString();
    }
}
