using Builder.Inferfaces;

namespace Builder.Classes
{
    public abstract class AbstractMeal : IMealComposite
    {
        private decimal Price { get; set; }
        private string Name {get;set;}
        public AbstractMeal(decimal Price, string Name)
        {
            this.Price = Price;
            this.Name = Name;
        }
        public decimal GetPrice()
        {
            return this.Price;
        }
    }
}