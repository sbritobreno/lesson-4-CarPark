using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_editted.models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();
        public CarParkCharge charges = new CarParkCharge();
        public double profitDay { get; set; }
        public void CalculateFee()
        {
            foreach (Customer currentCustomer in listOfCustomers)
            {
                double finalFee = charges.CalculateCharges(currentCustomer.hoursParked);
                Console.WriteLine($"---The final cost for the car registrated as {currentCustomer.carRegistration}, which had been parked for {currentCustomer.hoursParked} hours is: {finalFee} euro");

                profitDay += finalFee;
            }
        }
        public void ProfitDay()
        {
            Console.WriteLine("\n---the total profit of the day was : " + profitDay);
        }
    }
}
