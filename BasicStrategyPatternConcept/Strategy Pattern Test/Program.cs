using Strategy_Pattern_Test.Data;
using Strategy_Pattern_Test.Models;

namespace Strategy_Pattern_Test
{
    internal static class Program
    {
        // private static readonly IPassportDetails _passportDetails = new PassportDetails();    
        // private static readonly IBankSlipsDetails _bankSlipsDetails = new BankSlipsDetails();
        // potentially add IBankOfChris interface and IBankOfGary interface
        private static readonly ICustomerDetails _customerDetails = new CustomerDetails();
        
        public static void Main(string[] args)
        {
            var client = LendersEnum.BankOfChris;
            var carFinance = new CarFinanceRequiredObject();

            if (client == LendersEnum.BankOfChris)
            {
                carFinance.PassportRequired = true;
                carFinance.BankSlipsRequired = true;
                carFinance.DriversLicenceRequired = false;
                carFinance.VehicleLogsRequired = false;
                carFinance.VehicleMotRequired = true;
            }
            
            if (client == LendersEnum.BankOfGary)
            {
                carFinance.PassportRequired = true;
                carFinance.BankSlipsRequired = false;
                carFinance.DriversLicenceRequired = false;
                carFinance.VehicleLogsRequired = false;
                carFinance.VehicleMotRequired = false;
            }

            var customerDetails = new CustomerDetailsObject();

            if (carFinance.PassportRequired)
            {
                customerDetails.Passport = _customerDetails.GetPassport(client);
            }
            
            if (carFinance.DriversLicenceRequired)
            {
                customerDetails.DriversLicence = _customerDetails.GetDriversLicence(client);
            }
            
            if (carFinance.BankSlipsRequired)
            {
                customerDetails.BankSlips = _customerDetails.GetBankSlips(client);
            }
            
            if (carFinance.VehicleLogsRequired)
            {
                customerDetails.VehicleLogs = _customerDetails.GetVehicleLogs(client);
            }
            
            if (carFinance.VehicleMotRequired)
            {
                customerDetails.VehicleMot = _customerDetails.GetVehicleMot(client);
            }
            
            Console.WriteLine($"Passport - {customerDetails.Passport}");
            Console.WriteLine($"DriversLicence - {customerDetails.DriversLicence}");
            Console.WriteLine($"BankSlips - {customerDetails.BankSlips}");
            Console.WriteLine($"VehicleLogs - {customerDetails.VehicleLogs}");
            Console.WriteLine($"VehicleMot - {customerDetails.VehicleMot}");
        }
    }
}

