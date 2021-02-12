using System.Collections.Generic;
using Builder.Inferfaces;

namespace Builder.Classes
{
    public class MealBox : IMealComposite
    {
        private readonly List<IMealComposite> _children = new List<IMealComposite>();
        public decimal GetPrice()
        {
            decimal price = 0;
            foreach (var item in _children)            
                price += item.GetPrice();
            
            return price;
        }

        public void Add(IMealComposite mealComposite)
        {
            _children.Add(mealComposite);
        }
    }
}