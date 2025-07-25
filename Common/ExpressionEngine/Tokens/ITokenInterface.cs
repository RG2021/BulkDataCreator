
namespace Mockit.Common.ExpressionEngine.Tokens
{
    public interface ITokenInterface
    {
        string Name { get; }
        string Execute(string args);
    }
}
