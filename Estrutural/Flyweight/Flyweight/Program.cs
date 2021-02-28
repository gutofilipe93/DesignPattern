using System;
using Flyweight.delivery;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Todos esse caso os dicionario Location vai criar apenas um objeto na memória, pois todos eles tem o mesmo endereço(Rua e cidade) 
               Apenas Paulo vai ser um novo registro*/
            var factory = new DeliveryFactory();
            factory.CreateDelivery(factory,"Luiz","20A", "Av Brasil", "SP");
            factory.CreateDelivery(factory,"Helena","300", "Av Brasil", "SP");
            factory.CreateDelivery(factory,"Joana","512", "Av Brasil", "SP");
            factory.CreateDelivery(factory,"Paulo","125", "Domingos Javaroni", "SP");
            var locations = factory.GetLocations();
            Console.WriteLine($"{locations.Count}");
        }        
    }
}
