using Mockit.Models;
using System.Text.RegularExpressions;

namespace Mockit.Common.ExpressionEngine
{
    public class ExpressionEngine
    {
        private TokensRegistry _tokensRegistry;
        private readonly Regex ParamPattern = new Regex(@"\{\{\s*([\w\.]+)(\((.*?)\))?\s*\}\}");
        public ExpressionEngine() 
        {
            _tokensRegistry = new TokensRegistry();
        }

        public string Evaluate(string input, EvaluationRecord context = null)
        {
            return ParamPattern.Replace(input, match =>
            {
                string name = match.Groups[1].Value;
                string args = match.Groups[3].Success ? match.Groups[3].Value : null;

                if (context?.GetFieldValue(name) is string value)
                {
                    return value;
                }

                return _tokensRegistry.Evaluate(name, args);
            });
        }
    }
}