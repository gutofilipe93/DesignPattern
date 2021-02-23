namespace Composite
{
    public class ProductLeaf : ProductComponent
    {
        private readonly string _name;
        private readonly decimal _price;
        public ProductLeaf(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}