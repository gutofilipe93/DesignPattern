using Visitor;
using Visitor.Product;

namespace Visitor
{
    public class BrazilTaxVisitor : ITaxVisitor
    {
        public decimal CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink)
        {
            return alcoholicDrink.GetPrice() + (alcoholicDrink.GetPrice() * 0.5m);
        }

        public decimal CalculateTaxesForCigarette(Cigarette cigarette)
        {
            return cigarette.GetPrice() + (cigarette.GetPrice() * 1.5m);
        }

        public decimal CalculateTaxesForFood(Food food)
        {
            return food.GetPrice() + (food.GetPrice() * 0.05m);
        }
    }
}