using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;

public class FullAddressToken : BaseToken
{
    public override string Name => "FullAddress";

    public override string Execute(string args)
    {
        return Faker.Address.FullAddress();
    }
}
