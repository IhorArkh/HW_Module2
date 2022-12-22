using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class PassengerPlane : Airplane
    {
        public int NumOfSeats { get; }

        public PassengerPlane(int maxSpeed, int weight, int fuelTankVol, int numOfSeats)
            :base(maxSpeed, weight, fuelTankVol)
        {
            NumOfSeats = numOfSeats;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Fuel Tank Volume:{FuelTankVol}L, Number of seats:{NumOfSeats}");
        }
    }
}
