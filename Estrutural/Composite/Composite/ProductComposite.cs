using System.Collections.Generic;

namespace Composite
{
    public class ProductComposite : ProductComponent
    {
        private List<ProductComponent> children = new List<ProductComponent>(); 
        public override decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in children)            
                total += item.GetPrice();
            
            return total;
        }

        public override void Add(ProductComponent product)
        {
            children.Add(product);
        }

        public override void Remove(ProductComponent product)
        {
            children.Remove(product);
        }
    }
}