using System.Collections.Generic;
using System.Linq;

namespace Strategy_Pattern
{
    public interface IDecider
    {
        IStrategy GetStrategy(int id);
    }

    public class Decider : IDecider
    {
        public IStrategy GetStrategy(int id)
        {
            if (id == 1) return new StrategyA();

            if (id == 2) return new StrategyB();

            return null;
        }
    }

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
}