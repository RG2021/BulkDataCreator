using Mockit.Common.ExpressionEngine.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Common.ExpressionEngine
{
    public static class TokensRegistry
    {
        private static readonly Dictionary<TokenType, ITokenInterface> _tokens;

        static TokensRegistry()
        {
            _tokens = RegisterTokens();
        }
        public static Dictionary<TokenType, ITokenInterface> RegisterTokens()
        {
            return new Dictionary<TokenType, ITokenInterface>
            {
                [TokenType.FULLNAME] = new FullNameToken(),
                [TokenType.EMAIL] = new EmailToken(),
                [TokenType.NUMBER] = new NumberToken(),
                [TokenType.SELECT] = new SelectToken(),
                [TokenType.SEQUENCE] = new SequenceToken(),
                [TokenType.FULLADDRESS] = new FullAddressToken(),
                [TokenType.LOOKUP] = new LookupToken(),
                [TokenType.DATE] = new DateToken(),
                [TokenType.BOOLEAN] = new BooleanToken(),
                [TokenType.GUID] = new GuidToken()
            };
        }

        public static string Evaluate(string name, string args)
        {
            if (!Enum.TryParse(name.Trim(), ignoreCase: true, out TokenType tokenType))
                return $"{name}";

            return _tokens.TryGetValue(tokenType, out var token) ? token.Execute(args) : $"[Unregistered token: {tokenType}]";
        }
    }
}