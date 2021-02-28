using System;

namespace Flyweight.delivery
{
    public class DeliveryLocation : IDeliveryFlyweight
    {        
        public  readonly DeliveryLocationData _intrinsicState;
        public DeliveryLocation(DeliveryLocationData intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public void Deliver(string name, string number)
        {
            Console.WriteLine($"Entrega para %s {name}");
            Console.WriteLine($"Em {_intrinsicState.Street}, {_intrinsicState.City}");
            Console.WriteLine($"Número {number}");
            Console.WriteLine($"###");
        }
    }
}