using lesson_4_editted.models;
using System;

namespace lesson_4_editted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ### Car-Parking Application ### ");

            CarParkingManagement management = new CarParkingManagement();

            management.workingDay();

        }
    }
}
