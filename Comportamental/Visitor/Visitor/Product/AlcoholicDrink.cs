namespace Visitor.Product
{
    public class AlcoholicDrink : Product
    {
        public AlcoholicDrink(decimal price) : base("AlcoholicDrink", price)
        {
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public override decimal GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForAlcoholicDrink(this);
        }
    }
}