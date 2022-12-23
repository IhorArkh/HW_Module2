using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class RegularPlane : PassengerPlane
    {
        public bool IsWaterIncluded { get; }

        public RegularPlane(int maxSpeed, int weight, int fuelTankVol, int numOfSeats, bool isWaterIncluded)
            : base(maxSpeed, weight, fuelTankVol, numOfSeats)
        {
            IsWaterIncluded = isWaterIncluded;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Fuel Tank Volume:{FuelTankVol}L, Number of seats:{NumOfSeats}, Is water included:{IsWaterIncluded}");
        }

        public override void Move()
        {
            Console.WriteLine("I am flying with passengers!");
        }
    }
}
