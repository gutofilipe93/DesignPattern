using Visitor;
using Visitor.Product;

namespace Visitor
{
    public interface ITaxVisitor
    {
        decimal CalculateTaxesForFood(Food food);
        decimal CalculateTaxesForCigarette(Cigarette cigarette);
        decimal CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink);
    }
}