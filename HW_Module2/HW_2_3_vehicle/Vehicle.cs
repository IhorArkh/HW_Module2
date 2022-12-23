using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; }
        public int Weight { get; }

        public Vehicle(int maxSpeed, int weight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
        }

        public abstract void ShowInfo();
    }
}
