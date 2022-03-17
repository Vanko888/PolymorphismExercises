using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {

        }

        public double IsEmpty()
        {
            return this.fuelConsumptionPerKm;
        }

        public double BusWithPeople()
        {
            return this.fuelConsumptionPerKm = this.fuelConsumptionPerKm + 1.4;
        }
        
        
    }
}
