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
    }
}
