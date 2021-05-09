using Visitor;
using Visitor.Product;

namespace Visitor
{
    public class UsTaxVisitor : ITaxVisitor
    {
        public decimal CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink)
        {
            return alcoholicDrink.GetPrice() + (alcoholicDrink.GetPrice() * 1);
        }

        public decimal CalculateTaxesForCigarette(Cigarette cigarette)
        {
            return cigarette.GetPrice() + (cigarette.GetPrice() * 2);
        }

        public decimal CalculateTaxesForFood(Food food)
        {
            return food.GetPrice() + (food.GetPrice() * 0.15m);
        }
    }
}