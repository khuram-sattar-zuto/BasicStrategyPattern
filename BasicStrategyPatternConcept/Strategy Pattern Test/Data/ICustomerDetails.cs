using Strategy_Pattern_Test.Models;

namespace Strategy_Pattern_Test.Data;

public interface ICustomerDetails
{
    string GetPassport(LendersEnum lender);
    string GetDriversLicence(LendersEnum lender);
    string GetBankSlips(LendersEnum lender);
    string GetVehicleLogs(LendersEnum lender);
    string GetVehicleMot(LendersEnum lender);
}

public class CustomerDetails : ICustomerDetails
{
    public string GetPassport(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"Passport has been required for {lender.ToString()}";
    }

    public string GetDriversLicence(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"Drivers Licence has been required for {lender.ToString()}";
    }

    public string GetBankSlips(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"BankSlips has been required for {lender.ToString()}";
    }

    public string GetVehicleLogs(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"VehicleLogs has been required for {lender.ToString()}";
    }

    public string GetVehicleMot(LendersEnum lender)
    {
        //This is a bad example of code, however it is written for demo purposes
        return $"VehicleMot has been required for {lender.ToString()}";
    }
}