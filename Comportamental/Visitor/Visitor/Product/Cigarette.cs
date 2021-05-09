namespace Visitor.Product
{
    public class Cigarette : Product
    {
        public Cigarette(decimal price) : base("Cigarette", price)
        {
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public override decimal GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForCigarette(this);
        }
    }
}