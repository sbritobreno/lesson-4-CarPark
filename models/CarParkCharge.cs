using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_editted.models
{
    public class CarParkCharge
    {
        public int minimumHours { get; set; }
        public int minimumFee { get; set; }

        public CarParkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
        }
        public double CalculateCharges(int hoursParked)
        {
            int i;
            double extraPerHour = 0;

            for (i = 3; hoursParked > i; i++)
            {
                extraPerHour += 0.50;
            }
            return minimumFee + extraPerHour;
        }
    }
}
