using System;
using Builder.Classes;

namespace Builder
{
    class Program
    {
        //19:50
        static void Main(string[] args)
        {
            var mainDishBuilder = new MainDishBuilder();
            mainDishBuilder.MakeMeal();            
            Console.WriteLine(mainDishBuilder.GetMeal().GetPrice());

            mainDishBuilder.Reset();
            mainDishBuilder.MakeBeverage();
            Console.WriteLine(mainDishBuilder.GetMeal().GetPrice());

            var veganDishBuilder = new VeganDishBuilder();  
            veganDishBuilder.MakeMeal();
            Console.WriteLine(veganDishBuilder.GetMeal().GetPrice());
        }
    }
}
