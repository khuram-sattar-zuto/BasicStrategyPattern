using System;
using System.Collections.Generic;

namespace Strategy_Pattern
{
    internal class Program
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

            var decider = new Decider();
            var strategy = decider.GetStrategy(1);
            var resultC = strategy.DoAlgorithm(randomListB);
            Console.WriteLine($"Strategy result - {string.Join(",", resultC)}");
            
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