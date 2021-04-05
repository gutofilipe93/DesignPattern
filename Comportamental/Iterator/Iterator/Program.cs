using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("Primeiro");
            collection.AddItem("Segundo");
            collection.AddItem("Terceiro");

            Console.WriteLine("Original");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Ao Contrario");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
