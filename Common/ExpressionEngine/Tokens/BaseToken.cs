using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;

public abstract class BaseToken : ITokenInterface
{
    protected static readonly Faker Faker = new Faker();

    public abstract string Name { get; }
    public abstract string Execute(string args);

    protected static readonly Dictionary<string, int> _fieldSequenceCounters = new Dictionary<string, int>();
}