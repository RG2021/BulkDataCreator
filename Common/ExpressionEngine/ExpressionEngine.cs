using System.Text.RegularExpressions;

namespace Mockit.Common.ExpressionEngine
{
    public static class ExpressionEngine
    {
        private static readonly Regex ParamPattern = new Regex(@"\{\{\s*(\w+)(\((.*?)\))?\s*\}\}");

        public static string Evaluate(string input)
        {
            return ParamPattern.Replace(input, match =>
            {
                string name = match.Groups[1].Value;
                string args = match.Groups[3].Success ? match.Groups[3].Value : null;

                return TokensRegistry.Evaluate(name, args);
            });
        }
    }
}