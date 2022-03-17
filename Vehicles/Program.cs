using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelDty = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);
            if (carFuelDty > carTankCapacity)
            {
                carFuelDty = 0;
            }

            double truckFuelDty = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);
            if (truckFuelDty > truckTankCapacity)
            {
                truckFuelDty = 0;
            }

            double busFuelDty = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);
            if (busFuelDty > busTankCapacity)
            {
                busFuelDty = 0;
            }

            Car car = new Car(carFuelDty, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelDty, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelDty, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string vehicle = input[1];
                double number = double.Parse(input[2]);



                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        if (car.CanDrive(number))
                        {
                            car.Drive(number);
                            Console.WriteLine($"Car travelled {number} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (truck.CanDrive(number))
                        {
                            truck.Drive(number);
                            Console.WriteLine($"Truck travelled {number} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        bus.BusWithPeople();
                        if (bus.CanDrive(number))
                        {
                            bus.Drive(number);
                            Console.WriteLine($"Bus travelled {number} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }

                }
                else if (command == "Refuel")
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                        continue;
                    }
                    if (vehicle == "Car")
                    {
                        if (car.CanRefuel(number))
                        {
                            car.Refuel(number);
                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {number} fuel in the tank");
                        }

                    }
                    else if (vehicle == "Truck")
                    {
                        if (truck.CanRefuel(number))
                        {
                            truck.Refuel(number);
                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {number} fuel in the tank");
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        if (bus.CanRefuel(number))
                        {
                            bus.Refuel(number);
                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {number} fuel in the tank");
                        }
                    }
                }
                else if (command == "DriveEmpty")
                {
                    bus.IsEmpty();
                    if (bus.CanDrive(number))
                    {
                        bus.Drive(number);
                        Console.WriteLine($"Bus travelled {number} km");
                    }
                    else
                    {
                        Console.WriteLine("Bus needs refueling");
                    }
                }
            }

            Console.WriteLine($"Car: {car.fuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.fuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.fuelQuantity:F2}");
        }
    }
}
