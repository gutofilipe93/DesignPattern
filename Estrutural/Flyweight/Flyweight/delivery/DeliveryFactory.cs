using System.Collections.Generic;

namespace Flyweight.delivery
{
    public class DeliveryFactory
    {
        private Dictionary<string, DeliveryLocation> _locations = new Dictionary<string, DeliveryLocation>();

        public IDeliveryFlyweight MakeLocation(DeliveryLocationData intrinsicState)
        {
            var key = CreateId(intrinsicState);
            if(_locations.ContainsKey(key))
                return _locations[key];

            _locations[key] = new DeliveryLocation(intrinsicState);
            return _locations[key];
        } 

        private string CreateId(DeliveryLocationData data)
        {
            return data.Street.ToLower() + data.City.ToLower();
        }

        public void CreateDelivery(DeliveryFactory factory, string name, string number, string street, string city)
        {
            var location = factory.MakeLocation(new DeliveryLocationData {City = city, Street = street});
            location.Deliver(name, number);
        }

        public Dictionary<string, DeliveryLocation> GetLocations()
        {
            return _locations;
        }
    }
}