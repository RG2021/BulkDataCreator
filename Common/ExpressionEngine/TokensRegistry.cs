using Mockit.Common.ExpressionEngine.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Common.ExpressionEngine
{
    public class TokensRegistry
    {
        private static Dictionary<TokenType, ITokenInterface> _tokens;

        public TokensRegistry()
        {
            _tokens = RegisterTokens();
        }
        public static Dictionary<TokenType, ITokenInterface> RegisterTokens()
        {
            return new Dictionary<TokenType, ITokenInterface>
            {
                [TokenType.SELECT] = new SelectToken(),
                [TokenType.SEQUENCE] = new SequenceToken(),
                [TokenType.LOOKUP] = new LookupToken(),
                [TokenType.DATE] = new DateToken(),
                [TokenType.NUMBER] = new NumberToken(),
                [TokenType.BOGUS] = new BogusToken()
            };
        }

        public string Evaluate(string name, string args)
        {

            if (string.IsNullOrWhiteSpace(name) || name.Split('.').Length < 2)
                return $"[Unknown token: {name}]";

            string[] parts = name.Split('.');
            string property = parts[0].Trim().ToUpperInvariant();
            string method = parts[1].Trim().ToUpperInvariant();

            bool isCustomToken = string.Equals(property, "MOCK", StringComparison.OrdinalIgnoreCase);

            if (isCustomToken && Enum.TryParse(method, ignoreCase: true, out TokenType tokenType))
            {
                return _tokens.TryGetValue(tokenType, out ITokenInterface token) ? token.Execute(args) : $"[Unregistered token: {method}]";
            }
            else if(!isCustomToken && _tokens.TryGetValue(TokenType.BOGUS, out var bogusToken))
            {
                string result = string.IsNullOrEmpty(args) ? $"{name}" : $"{name}({args})";
                return bogusToken.Execute(result);
            }
            else
            {
                return $"[Unknown token: {name}]";
            }
        }
    }
}