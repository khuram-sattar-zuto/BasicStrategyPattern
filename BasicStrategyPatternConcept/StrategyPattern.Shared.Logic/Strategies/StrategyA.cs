namespace StrategyPattern.Shared.Logic.Strategies
{
    public class StrategyA : IStrategy
    {
        public int Identifier { get; } = 1;

        public List<string> DoAlgorithm(List<string> data)
        {
            data.Sort();
            return data;
        }
    }
}