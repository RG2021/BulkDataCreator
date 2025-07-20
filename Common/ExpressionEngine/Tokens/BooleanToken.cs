using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System;
using System.Globalization;

public class BooleanToken : BaseToken
{
    public override string Name => "Boolean";
    public override string Expression => "{{ BOOLEAN }}";

    public override string Execute(string args)
    {
        return Faker.Random.Bool() ? "1" : "0";
    }
}
