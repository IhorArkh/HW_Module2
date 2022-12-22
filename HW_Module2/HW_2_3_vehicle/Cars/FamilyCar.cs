using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class FamilyCar : Car
    {
        public int RateOfSafety { get; }

        public FamilyCar(int maxSpeed, int weight, string brand, int numOfDoors, int rateOfSafety)
            : base(maxSpeed, weight, brand, numOfDoors)
        {
            RateOfSafety = rateOfSafety;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Brand:{Brand}, Doors:{NumOfDoors}, Rate of safety:{RateOfSafety}");
        }
    }
}
