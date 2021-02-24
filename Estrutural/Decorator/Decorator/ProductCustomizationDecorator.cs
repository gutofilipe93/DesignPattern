namespace Decorator
{
    public class ProductCustomizationDecorator : ProductDecorator
    {
        public ProductCustomizationDecorator(IProductComponent product) : base(product)
        {
        }

        public override string GetName()
        {
            return _product.GetName() + " (Customização)";
        }

        public override decimal GetPrice()
        {
            return _product.GetPrice() + 50;
        }
    }
}