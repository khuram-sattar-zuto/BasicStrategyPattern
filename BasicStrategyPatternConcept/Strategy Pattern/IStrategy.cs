using System.Collections.Generic;

namespace Strategy_Pattern
{
    public interface IStrategy
    {
        int Identifier { get; }
        List<string> DoAlgorithm(List<string> data);
    }
}