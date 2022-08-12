using StrategyPattern.Shared.Logic.Strategies;

namespace StrategyPattern.Shared.Logic.Deciders;

public class Decider : IDecider
{
    public IStrategy GetStrategy(int id)
    {
        if (id == 1) return new StrategyA();

        if (id == 2) return new StrategyB();

        return null;
    }
}