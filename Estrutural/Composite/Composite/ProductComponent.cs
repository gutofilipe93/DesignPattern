namespace Composite
{
    public abstract class ProductComponent
    {
        public abstract decimal GetPrice();

        public virtual void Add(ProductComponent product){}
        public virtual void Remove(ProductComponent product){}
    }
}