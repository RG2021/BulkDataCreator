using Bogus;

public class EmailToken : BaseToken
{
    public override string Name => "EMAIL";

    public override string Execute(string args = null)
    {
        return Faker.Internet.Email();
    }
}