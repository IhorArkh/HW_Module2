using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class F1Car : SportCar
    {
        public string NameOfSponsor { get; }

        public F1Car(int maxSpeed, int weight, string brand, int numOfDoors, bool allowedToDriveOnRoads, string nameOfSponsor)
            : base (maxSpeed, weight, brand, numOfDoors, allowedToDriveOnRoads)
        {
            NameOfSponsor = nameOfSponsor;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Brand:{Brand}, Doors:{NumOfDoors}, Allowed to drive on roads:{AllowedToDriveOnRoads}, Sponsor:{NameOfSponsor}");
        }

        public override void Move()
        {
            Console.WriteLine("I am driving on F1 Track!");
        }
    }
}
