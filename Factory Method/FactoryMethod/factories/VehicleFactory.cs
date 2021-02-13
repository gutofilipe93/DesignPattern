using FactoryMethod.vehicle;

namespace FactoryMethod.factories
{
    // Factory Method
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicleName);

        public static VehicleFactory CreateVehicle(string typeVehicle)
        {
            if (typeVehicle.ToLower() == "carro")
                return new CarFactory();
            else if (typeVehicle.ToLower() == "bicicleta")
                return new BicycleFactory();

            return null;
        }
    }
}