using Strategy_Pattern_Test.Models;

namespace Strategy_Pattern_Test.Data;

public interface IBankSlipsDetails
{
    string Get(LendersEnum lender);
}

public class BankSlipsDetails : IBankSlipsDetails
{
    public string Get(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"BankSlips has been required for {lender.ToString()}";
    }
}