using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.Trains
{
    public class PassengerTrain : Train
    {
        public int ClassOfTrain { get; }
        public PassengerTrain(int maxSpeed, int weight, int numOfWagons, int classOfTrain) : base(maxSpeed, weight, numOfWagons)
        {
            ClassOfTrain= classOfTrain;
        }
    }
}
