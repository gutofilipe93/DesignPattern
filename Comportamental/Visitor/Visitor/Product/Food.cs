namespace Visitor.Product
{
    public class Food : Product
    {
        public Food(decimal price) : base("Food", price)
        {
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public override decimal GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForFood(this);
        }
    }
}