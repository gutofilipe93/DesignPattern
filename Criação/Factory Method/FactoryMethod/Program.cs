using System;
using FactoryMethod.factories;

namespace FactoryMethod
{
    class Program
    {        
        static void Main(string[] args)
        {
            var factory = VehicleFactory.CreateVehicle("carro");
            var vehicle = factory.GetVehicle("Fusca");
            Console.WriteLine(vehicle.PickUp("Gustavo"));
            Console.WriteLine(vehicle.Stop());

            factory = VehicleFactory.CreateVehicle("bicicleta");
            vehicle = factory.GetVehicle("Bike");
            Console.WriteLine(vehicle.PickUp("Gustavo"));
            Console.WriteLine(vehicle.Stop());
        }
    }
}
