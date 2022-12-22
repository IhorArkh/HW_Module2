using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class PrivateJet : PassengerPlane
    {
        public string OwnerName { get; }

        public PrivateJet (int maxSpeed, int weight, int fuelTankVol, int numOfSeats, string ownerName)
            : base(maxSpeed, weight, fuelTankVol, numOfSeats)
        {
            OwnerName = ownerName;
        }
    }
}
