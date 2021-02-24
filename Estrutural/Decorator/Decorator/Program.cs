using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tShirt = new TShirtComponent();
            var tShirtWithStamp  = new ProductStampDecorator(tShirt);
            var customizedTShirt = new ProductCustomizationDecorator(tShirt);

            Console.WriteLine(tShirt.GetName() + " - " + tShirt.GetPrice());
            Console.WriteLine(tShirtWithStamp.GetName() + " - " + tShirtWithStamp.GetPrice());
            Console.WriteLine(customizedTShirt.GetName() + " - " + customizedTShirt.GetPrice());

            // Adicionando um decorator dentro do outro
            var test = new ProductStampDecorator(customizedTShirt);

            Console.WriteLine(test.GetName() + " - " + test.GetPrice());
        }
    }
}
