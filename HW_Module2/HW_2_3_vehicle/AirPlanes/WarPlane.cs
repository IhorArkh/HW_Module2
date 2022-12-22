﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3_vehicle.AirPlanes
{
    public class WarPlane : Airplane
    {
        public string WeaponType { get; }

        public WarPlane(int maxSpeed, int weight, int fuelTankVol, string weaponType)
            : base(maxSpeed, weight, fuelTankVol)
        {
            WeaponType = weaponType;
        }
    }
}