using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;

public class FullNameToken : BaseToken
{
    public override string Name => "FULLNAME";
    public override string Expression => "{{ FULLNAME }}";

    public override string Execute(string args)
    {
        return Faker.Name.FullName();
    }
}