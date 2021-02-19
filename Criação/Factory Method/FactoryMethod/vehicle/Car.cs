namespace FactoryMethod.vehicle
{
    public class Car : IVehicle
    {
        private readonly string _name;
        public Car(string name)
        {
            _name = name;
        }

        public string PickUp(string customerName)
        {
            return $"{_name} está buscando {customerName}";
        }

        public string Stop()
        {
            return $"{_name} parou";
        }
    }
}