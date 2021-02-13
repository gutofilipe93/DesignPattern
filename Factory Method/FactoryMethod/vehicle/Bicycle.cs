namespace FactoryMethod.vehicle
{
    public class Bicycle : IVehicle
    {
        private readonly string _name;

        public Bicycle(string name)
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