using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_editted.models
{

    public class CarParkingManagement
    {
        public CarPark parking = new CarPark();
        public CarParkingManagement()
        {
            Console.WriteLine("     THIS IS THE HISTORY OF:");
        }

        public void workingDay()
        {
            Console.WriteLine("         # 06/10/2021 # ");

            Console.WriteLine();

            Customer Car1 = new Customer("car-0001", 2);
            Console.WriteLine(Car1.ToString());

            Customer Car2 = new Customer("car-0002", 4);
            Console.WriteLine(Car2.ToString());

            Customer Car3 = new Customer("car-0003", 6);
            Console.WriteLine(Car3.ToString());

            Console.WriteLine();

            parking.listOfCustomers.Add(Car1);
            parking.listOfCustomers.Add(Car2);
            parking.listOfCustomers.Add(Car3);

            parking.CalculateFee();
            parking.ProfitDay();

        }
    }
}
