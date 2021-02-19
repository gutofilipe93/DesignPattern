using FactoryMethod.vehicle;

namespace FactoryMethod.factories
{
    public class BicycleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Bicycle(vehicleName);
        }
    }
}