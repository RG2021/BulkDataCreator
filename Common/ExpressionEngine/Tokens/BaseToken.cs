using Bogus;
using Mockit.Common.ExpressionEngine.Tokens;
using System.Collections.Generic;

public abstract class BaseToken : ITokenInterface
{
    protected static readonly Faker Faker = new Faker();
    protected static readonly Dictionary<string, int> _fieldSequenceCounters = new Dictionary<string, int>();

    public abstract string Name { get; }
    public abstract string Execute(string args);

    
}