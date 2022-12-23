using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class SportCar : Car, IMoveable
    {
        public bool AllowedToDriveOnRoads { get; }

        public SportCar (int maxSpeed, int weight, string brand, int numOfDoors, bool allowedToDriveOnRoads) 
            : base (maxSpeed, weight, brand, numOfDoors)
        {
            AllowedToDriveOnRoads = allowedToDriveOnRoads;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Brand:{Brand}, Doors:{NumOfDoors}, Allowed to drive on roads:{AllowedToDriveOnRoads}");
        }
        public void Move()
        {
            Console.WriteLine("I am driving fast!");
        }
    }
}
