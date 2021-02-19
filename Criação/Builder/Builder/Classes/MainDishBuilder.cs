using Builder.Inferfaces;

namespace Builder.Classes
{
    public class MainDishBuilder : IMealBuilder
    {
        private MealBox _meal = new MealBox();
        public IMealBuilder MakeBeverage()
        {
            _meal.Add(new Beverage(2.09m,"Cristal"));
            return this;
        }

        public IMealBuilder MakeDessrt()
        {
            _meal.Add(new Dessert(15,"Bolo"));
            return this;
        }

        public IMealBuilder MakeMeal()
        {            
            _meal.Add(new Rice(12,"Arroz"));
            _meal.Add(new Beans(5,"Feijão"));
            _meal.Add(new Meat(28,"Carne"));
            return this;
        }

        public MealBox GetMeal()
        {
            return _meal;
        }

        public void Reset()
        {
            this._meal = new MealBox();
        }

        public decimal GetPrice()
        {
            return _meal.GetPrice(); 
        }
    }
}