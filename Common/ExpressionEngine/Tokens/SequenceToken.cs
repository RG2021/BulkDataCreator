using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls.WebParts;

public class SequenceToken : BaseToken
{
    private readonly object _lock = new object();
    private readonly Dictionary<string, int> _fieldSequenceCounters = new Dictionary<string, int>();

    public override string Name => "Sequence";

    public override string Execute(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return "0";

        int seqIndex = args.IndexOf(',');
        if (seqIndex < 0)
            return "[Invalid format. Use: MOCK.SEQUENCE(sequenceid, (value1, value2, etc))]";

        int valuesIndex = args.IndexOf('(', seqIndex + 1);
        if (valuesIndex < 0 || !args.EndsWith(")"))
            return "[Invalid format. Use: MOCK.SEQUENCE(sequenceid, (value1, value2, etc))]";

        string seqID = args.Substring(0, seqIndex).Trim();
        string valuesPart = args.Substring(valuesIndex).Trim();

        valuesPart = valuesPart.Trim('(', ')', ' ');
        string[] values = valuesPart.Split(',', (char)StringSplitOptions.RemoveEmptyEntries).Select(v => v.Trim()).ToArray();

        if(string.IsNullOrEmpty(seqID) || values.Length == 0)
            return "[Invalid sequence ID or values]";

        lock (_lock)
        {
            if (!_fieldSequenceCounters.TryGetValue(seqID, out int index) || index >= values.Length)
            {
                index = 0;
            }
            _fieldSequenceCounters[seqID] = index + 1;
            return values[index];
        }
    }

}
