using StrategyPattern.Shared.Logic.Deciders;

namespace Strategy_Pattern_Decider
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var randomList = new List<string>{ "C", "B", "A"};
            var randomListB = new List<string>{ "C", "B", "A"};

            var decider = new Decider();
            var strategy = decider.GetStrategy(1);
            var resultC = strategy.DoAlgorithm(randomListB);
            Console.WriteLine($"Strategy result - {string.Join(",", resultC)}");
        }
    }
}