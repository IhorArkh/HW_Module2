using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class Car : Vehicle
    {
        public string Brand { get; }
        public int NumOfDoors { get; }
        public Car(int maxSpeed, int weight, string brand, int numOfDoors) : base(maxSpeed, weight)
        {
            Brand = brand;
            NumOfDoors = numOfDoors;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Speed:{MaxSpeed}km/h, Weight:{Weight}kg, Brand:{Brand}, Number of doors:{NumOfDoors}");
        }
    }
}
