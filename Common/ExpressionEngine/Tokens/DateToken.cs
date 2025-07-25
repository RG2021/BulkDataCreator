using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Globalization;

public class DateToken : BaseToken
{
    private static readonly string _dateFormat = "yyyy-MM-dd";

    public override string Name => "Date";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "[Missing date range. Use: DATE(minDate, maxDate)]";

        string[] parts = args.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2)
            return "[Invalid format. Use: DATE(minDate, maxDate)]";

        if (!DateTime.TryParse(parts[0].Trim(),  out DateTime minDate) || !DateTime.TryParse(parts[1].Trim(), out DateTime maxDate))
        {
            return "[Invalid dates. Expected format: yyyy-MM-dd]";
        }

        if (minDate > maxDate)
            return "[Min date should be less than or equal to max date]";

        DateTime randomDate = Faker.Date.Between(minDate, maxDate);
        return randomDate.ToString(_dateFormat);
    }
}
