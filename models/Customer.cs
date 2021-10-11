using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_editted.models
{
    public class Customer
    {
        public string carRegistration { get; set; }
        public int hoursParked { get; set; }
        public Customer(string _carRegistration, int _hoursParked)
        {
            carRegistration = _carRegistration;
            hoursParked = _hoursParked;
        }
        public override string ToString()
        {
            return $"---New car registrated: {carRegistration}, parked for {hoursParked} hours.";
        }
    }
}
