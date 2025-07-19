using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Globalization;

public class GuidToken : BaseToken
{
    public override string Name => "Guid";

    public override string Execute(string args)
    {
        return Faker.Random.Guid().ToString();
    }
}
