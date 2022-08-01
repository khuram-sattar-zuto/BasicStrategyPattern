using System.Collections.Generic;

namespace Strategy_Pattern
{
    public class StrategyB : IStrategy
    {
        public int Identifier { get; } = 2;

        public List<string> DoAlgorithm(List<string> data)
        {
            data.AddRange(new []{"Z", "Y"});
            return data;
        }
    }
}