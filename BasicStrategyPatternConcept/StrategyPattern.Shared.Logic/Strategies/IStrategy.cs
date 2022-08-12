namespace StrategyPattern.Shared.Logic.Strategies
{
    public interface IStrategy
    {
        int Identifier { get; }
        List<string> DoAlgorithm(List<string> data);
    }
}