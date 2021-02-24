namespace Decorator
{
    public class TShirtComponent : IProductComponent
    {
        private string _name = "Camiseta";
        private decimal _price = 49.9m;

        public string GetName()
        {
            return this._name;
        }

        public decimal GetPrice()
        {
            return this._price;
        }
    }
}