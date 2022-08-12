using StrategyPattern.Shared.Logic.Strategies;

namespace StrategyPattern.Shared.Logic.Deciders
{
    public interface IDecider
    {
        IStrategy GetStrategy(int id);
    }
}