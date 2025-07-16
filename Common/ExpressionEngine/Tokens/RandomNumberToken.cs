
using Bogus;
public class RandomNumberToken : BaseToken
{
    public override string Name => "RANDOM";
    public override string Execute(string args = null)
    {
        string[] parts = args?.Split(',');
        if (parts == null || parts.Length < 2)
            return "0";

        bool isMinValid = int.TryParse(parts[0], out int min);
        bool isMaxValid = int.TryParse(parts[1], out int max);

        if (isMinValid && isMaxValid)
            return Faker.Random.Number(min, max).ToString();

        return "0";
    }
}