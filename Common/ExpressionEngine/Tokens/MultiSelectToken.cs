using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Common.ExpressionEngine.Tokens
{
    internal class MultiSelectToken : BaseToken
    {
        public override string Name => "MULTISELECT";
        public override string Execute(string args)
        {
            if (string.IsNullOrWhiteSpace(args))
                return "0";

            int countIndex = args.IndexOf(',');
            if (countIndex < 0)
                return "[Invalid format. Use: MOCK.MULTISELECT(count, (option1, option2, etc))]";

            int valuesIndex = args.IndexOf('(', countIndex + 1);
            if (valuesIndex < 0 || !args.EndsWith(")"))
                return "[Invalid format. Use: MOCK.MULTISELECT(count, (option1, option2, etc))]";

            string count = args.Substring(0, countIndex).Trim();
            string valuesPart = args.Substring(valuesIndex).Trim();

            valuesPart = valuesPart.Trim('(', ')', ' ');
            string[] values = valuesPart.Split(',', (char)StringSplitOptions.RemoveEmptyEntries).Select(v => v.Trim()).ToArray();

            if (!int.TryParse(count, out int intCount) || values.Length == 0  || intCount > values.Length)
                return "[Invalid count or exceeds available options]";

            string[] randomValues = Faker.Random.ArrayElements(values, intCount).ToArray();
            return string.Join(", ", randomValues);
        }
    }
}
