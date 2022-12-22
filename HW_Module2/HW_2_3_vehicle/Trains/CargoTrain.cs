using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.Trains
{
    public class CargoTrain : Train
    {
        public string CargoType { get; }

        public CargoTrain(int maxSpeed, int weight, int numOfWagons, string cargoType) : base (maxSpeed, weight, numOfWagons)
        {
            CargoType = cargoType;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Wagons:{NumOfWagons}, Type of cargo:{CargoType}");
        }
    }
}
