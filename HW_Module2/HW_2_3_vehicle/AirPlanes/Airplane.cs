using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class Airplane : Vehicle
    {
        public int FuelTankVol { get; }

        public Airplane(int maxSpeed, int weight, int fuelTankVol) :base(maxSpeed, weight)
        {
            FuelTankVol= fuelTankVol;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Fuel Tank Volume:{FuelTankVol}");
        }

        public override void Move()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
