
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double fuelQuantity { get; set; }
        public virtual double fuelConsumptionPerKm  { get; set; }

        public double tankCapacity { get; set; }

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.tankCapacity = tankCapacity;
        }

        public bool CanDrive(double km) => this.fuelQuantity - (km * this.fuelConsumptionPerKm) >= 0;
        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.fuelQuantity -= km * this.fuelConsumptionPerKm;
            }
        }

        public bool CanRefuel(double amount) => (fuelQuantity + amount) <= tankCapacity;
        public virtual void Refuel(double amount)
        {
            if (CanRefuel(amount))
            {
                this.fuelQuantity += amount;
            }
            
        }

    }
}
