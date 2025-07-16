using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;

public abstract class BaseToken : ITokenInterface
{
    protected static readonly Faker Faker = new Faker();

    public abstract string Name { get; }
    public abstract string Execute(string args);
}