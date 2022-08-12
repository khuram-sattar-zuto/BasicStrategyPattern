using Strategy_Pattern_Test.Models;

namespace Strategy_Pattern_Test.Data;

public interface IPassportDetails
{
    string Get(LendersEnum lender);
    string Add(LendersEnum lender);
}

public class PassportDetails : IPassportDetails
{
    public string Get(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"Passport has been required for {lender.ToString()}";
    }

    public string Add(LendersEnum lender)
    {
        throw new NotImplementedException();
    }
}