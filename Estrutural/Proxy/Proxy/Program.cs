using System;
using Proxy.System_user;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new SystemUserProxy("Luiz", "luizotavio");
            Console.WriteLine("Isso vai levar 2 segundo");
            var addresses =  user.GetAddresses();
            Console.WriteLine($"{addresses[0].Street} - {addresses[0].Number}");

            Console.WriteLine("Isso vai se repetir");
            for (int i = 0; i < 5; i++)
            {
                addresses =  user.GetAddresses();
                Console.WriteLine($"{addresses[0].Street} - {addresses[0].Number}");
            } 
        }
    }
}
