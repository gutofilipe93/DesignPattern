using System;
using System.Collections.Generic;
using System.Linq;
using Visitor.Product;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = new Food(10);
            var alcoholicDrink = new AlcoholicDrink(5);
            var cigarette = new Cigarette(5);

            food.AddProduct(food);
            food.AddProduct(alcoholicDrink);
            food.AddProduct(cigarette);

            var totalWithBrazilTaxes = food.GetPriceWithTaxes(new BrazilTaxVisitor()) + alcoholicDrink.GetPriceWithTaxes(new BrazilTaxVisitor()) + cigarette.GetPriceWithTaxes(new BrazilTaxVisitor()); 
            var totalWithUsTaxes = food.GetPriceWithTaxes(new UsTaxVisitor()) + alcoholicDrink.GetPriceWithTaxes(new UsTaxVisitor()) + cigarette.GetPriceWithTaxes(new UsTaxVisitor()); 

            Console.WriteLine($"O valor total em reais é: {food.TotalPrice()}");
            Console.WriteLine($"O valor com impostos no Brasil: {totalWithBrazilTaxes}");
            Console.WriteLine($"O valor com impostos no Us: {totalWithUsTaxes}");
        }
    }
}
