using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;
using System.Linq;

public class SequenceToken : BaseToken
{
    private readonly object _lock = new object();
    //private static readonly Dictionary<string, int> _fieldSequences = new Dictionary<string, int>();

    public override string Name => "Sequence";
    public override string Expression => "{{ SEQUENCE(fieldName, minValue, maxValue) }}";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "0";

        var parts = args.Split(',').Select(p => p.Trim()).ToArray();

        if (parts.Length < 3)
            return "[Invalid format. Use: SEQUENCE(fieldName, minValue, maxValue)]";

        string fieldName = parts[0];

        if (!int.TryParse(parts[1], out int min) || !int.TryParse(parts[2], out int max))
            return "[Invalid min/max]";

        lock (_lock)
        {
            if (!_fieldSequenceCounters.TryGetValue(fieldName, out int current) || current > max)
            {
                current = min;
            }

            _fieldSequenceCounters[fieldName] = current + 1;
            return current.ToString();
        }
    }

}
