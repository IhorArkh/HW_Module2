using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.Trains
{
    public class Train : Vehicle
    {
        public int NumOfWagons { get; }

        public Train(int maxSpeed, int weight, int numOfWagons) : base(maxSpeed, weight)
        {
            NumOfWagons= numOfWagons;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Wagons:{NumOfWagons}");
        }

        public override void Move()
        {
            Console.WriteLine("I am moving on rails!");
        }
    }
}
