using StrategyPattern.Shared.Logic.Strategies;

namespace StrategyPattern.Shared.Logic.Deciders;

public class GenericDecider : IDecider
{
    private readonly IEnumerable<IStrategy> _strategies;

    public GenericDecider()
    {
        _strategies = new List<IStrategy>
        {
            new StrategyA(),
            new StrategyB()
        };
    }

    public IStrategy GetStrategy(int id)
    {
        return _strategies.FirstOrDefault(x => x.Identifier == id);
    }
}