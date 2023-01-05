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

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Wagons:{NumOfWagons}, Train class:{ClassOfTrain}class");
        }

        public override void Move()
        {
            Console.WriteLine("I am moving on rails with passengers!");
        }
    }
}
