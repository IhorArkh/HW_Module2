using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle
{
    public class Garage
    {
        private Vehicle[] _vehicles = new Vehicle[13];

        private int _counter = 0;

        public void AddToGarage(Vehicle vehicle)
        {
            _vehicles[_counter] = vehicle;
            _counter++;
        }

        public void ShowVehicalInfo(Vehicle vehicle1)
        {
            vehicle1.ShowInfo();
        }

        public void ShowGarage()
        {
            for (int i = 0; i < _vehicles.Length; i ++)
            {
                _vehicles[i].ShowInfo();
            }
        }

        public void SortGarage()
        {
            Array.Sort(_vehicles);
        }

        public void FindBySpeed()
        {
            Console.WriteLine("Enter speed:");
            int speed = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i].MaxSpeed == speed)
                {
                    _vehicles[i].ShowInfo();
                    break;
                }
                else if (i == _vehicles.Length - 1)
                {
                    Console.WriteLine("Vehicle with this MaxSpeed does not exist in current garage :(");
                }
            }
        }

        public void MoveVehicleFromGarage()
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                _vehicles[i].ShowInfo();
                _vehicles[i].Move();
            }
        }
    }
}
