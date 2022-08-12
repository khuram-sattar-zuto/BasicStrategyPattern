using StrategyPattern.Shared.Logic.Strategies;

namespace Strategy_Pattern
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var randomList = new List<string>{ "C", "B", "A"};
            var strategyA = new StrategyA();
            var result = strategyA.DoAlgorithm(randomList);
            Console.WriteLine($"Strategy A result - {string.Join(",", result)}");
            
            var randomListB = new List<string>{ "C", "B", "A"};
            var strategyB = new StrategyB();
            var resultB = strategyB.DoAlgorithm(randomListB);
            Console.WriteLine($"Strategy B result - {string.Join(",", resultB)}");
        }
    }
}