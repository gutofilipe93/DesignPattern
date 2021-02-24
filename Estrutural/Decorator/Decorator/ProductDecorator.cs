namespace Decorator
{
    public abstract class ProductDecorator : IProductComponent
    {
        protected IProductComponent _product;

        public ProductDecorator(IProductComponent product)
        {
            _product = product;
        }

        public virtual string GetName()
        {
            return _product.GetName();
        }

        public virtual decimal GetPrice()
        {
            return _product.GetPrice();
        }
    }
}