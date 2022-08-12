using StrategyPattern.Shared.Logic.Deciders;

namespace Strategy_Pattern_Generic_Decider
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var randomListD = new List<string>{ "C", "B", "A", "X"};
            var genericDecider = new GenericDecider();
            var genericStrategy = genericDecider.GetStrategy(2);
            var resultD = genericStrategy.DoAlgorithm(randomListD);
            Console.WriteLine($"Generic Strategy result - {string.Join(",", resultD)}");
            
            genericStrategy = genericDecider.GetStrategy(1);
            var resultD2 = genericStrategy.DoAlgorithm(randomListD);
            Console.WriteLine($"Generic Strategy result called twice - {string.Join(",", resultD2)}");
        }
    }
}