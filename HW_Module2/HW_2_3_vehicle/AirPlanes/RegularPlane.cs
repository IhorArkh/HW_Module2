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
    }
}
