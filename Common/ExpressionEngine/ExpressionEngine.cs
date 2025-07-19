using Mockit.Models;
using System.Text.RegularExpressions;

namespace Mockit.Common.ExpressionEngine
{
    public static class ExpressionEngine
    {
        private static readonly Regex ParamPattern = new Regex(@"\{\{\s*(\w+)(\((.*?)\))?\s*\}\}");

        public static string Evaluate(string input, EvaluationRecord context = null)
        {
            return ParamPattern.Replace(input, match =>
            {
                string name = match.Groups[1].Value;
                string args = match.Groups[3].Success ? match.Groups[3].Value : null;

                if (context?.GetFieldValue(name) is string value)
                {
                    return value;
                }

                return TokensRegistry.Evaluate(name, args);
            });
        }
    }
}