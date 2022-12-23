using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class RallyCar : SportCar
    {
        public string NameOfTyres { get; }

        public RallyCar(int maxSpeed, int weight, string brand, int numOfDoors, bool allowedToDriveOnRoads, string nameOfTyres)
            : base(maxSpeed, weight, brand, numOfDoors, allowedToDriveOnRoads)
        {
            NameOfTyres= nameOfTyres;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Brand:{Brand}, Doors:{NumOfDoors}, Allowed to drive on roads:{AllowedToDriveOnRoads}, Tyres:{NameOfTyres}");
        }

        public override void Move()
        {
            Console.WriteLine("I am driving in WRC race!");
        }
    }
}
