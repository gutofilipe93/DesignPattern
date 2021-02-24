namespace Decorator
{
    public class ProductStampDecorator : ProductDecorator
    {
        public ProductStampDecorator(IProductComponent product) : base(product)
        {
        }

        public override string GetName()
        {
            return _product.GetName() + " (Estampada)";
        }

        public override decimal GetPrice()
        {
            return _product.GetPrice() + 10;
        }
    }
}