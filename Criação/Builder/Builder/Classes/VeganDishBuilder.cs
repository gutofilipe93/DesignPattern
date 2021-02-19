using Builder.Inferfaces;

namespace Builder.Classes
{
    public class VeganDishBuilder : IMealBuilder
    {
        private MealBox _meal = new MealBox();

        public void Reset()
        {
            this._meal = new MealBox();
        }

        public IMealBuilder MakeMeal()
        {
            _meal.Add(new Rice(12,"Arroz"));
            _meal.Add(new Beans(5,"Feijão"));
            return this;
        }

        public MealBox GetMeal()
        {
            return _meal;
        }
    }
}