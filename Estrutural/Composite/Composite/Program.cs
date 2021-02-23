using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var pen = new ProductLeaf("Canete", 2);
            var smartphone = new ProductLeaf("Ipnohe", 5000);
            var tShirt = new ProductLeaf("Camisa", 40);
            var productBox = new ProductComposite();
            productBox.Add(pen);
            productBox.Add(smartphone);
            productBox.Add(tShirt);
            
            // Outra caixa
            var tablet = new ProductLeaf("Tablet", 2000);
            var kindle = new ProductLeaf("Kindle", 400);
            var anotherProductBox = new ProductComposite();
            anotherProductBox.Add(tablet);
            anotherProductBox.Add(kindle);
            productBox.Add(anotherProductBox);

            Console.WriteLine(productBox.GetPrice()); // O resultado é a soma das duas caixa
        }
    }
}
