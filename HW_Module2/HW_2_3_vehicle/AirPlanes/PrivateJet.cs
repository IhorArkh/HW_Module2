using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class PrivateJet : PassengerPlane, IMoveable
    {
        public string OwnerName { get; }

        public PrivateJet (int maxSpeed, int weight, int fuelTankVol, int numOfSeats, string ownerName)
            : base(maxSpeed, weight, fuelTankVol, numOfSeats)
        {
            OwnerName = ownerName;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Fuel Tank Volume:{FuelTankVol}L, Number of seats:{NumOfSeats}, Name of owner:{OwnerName}");
        }
        public void Move()
        {
            Console.WriteLine("I am flying with my owner!");
        }
    }
}
