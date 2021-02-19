using FactoryMethod.vehicle;

namespace FactoryMethod.factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Car(vehicleName);
        }
    }
}