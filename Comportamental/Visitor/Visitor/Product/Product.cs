using System.Collections.Generic;
using System.Linq;

namespace Visitor.Product
{
    public abstract class Product
    {
        protected string Name { get; set; }
        protected decimal Price { get; set; }
        private List<Product> _products; 
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal TotalPrice ()
        {
            return _products.Sum(x => x.Price);
        }

        public abstract decimal GetPriceWithTaxes(ITaxVisitor visitor);
    }
}