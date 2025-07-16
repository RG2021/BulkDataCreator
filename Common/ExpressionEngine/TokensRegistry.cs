using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace Mockit.Common.ExpressionEngine
{
    public static class TokensRegistry
    {
        private static readonly Dictionary<string, ITokenInterface> _tokens;

        static TokensRegistry()
        {
            _tokens = new List<ITokenInterface>
            {
                new FullNameToken(),
                new EmailToken(),
                new RandomNumberToken(),
                new SelectToken()
            }
            .ToDictionary(f => f.Name.ToUpperInvariant(), f => f);
        }

        public static string Evaluate(string name, string args)
        {
            name = name.Trim().ToUpperInvariant();
            return _tokens.TryGetValue(name, out ITokenInterface function) ? function.Execute(args) : $"[Unknown token: {name}]";
        }
    }
}