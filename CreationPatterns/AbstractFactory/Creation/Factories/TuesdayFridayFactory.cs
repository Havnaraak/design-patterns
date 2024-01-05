using AbstractFactory.Creation.Interfaces;
using AbstractFactory.Product.Products;

namespace AbstractFactory.Creation.Factories
{
    public class TuesdayFridayFactory : IFactory
    {
        public TuesdayFridayFactory()
        {
            GetDailyRoutine();
        }

        public void GetDailyRoutine()
        {
            Console.WriteLine("TuesdayFridayFactory");
            var diet = new TuesdayFridayDiet();
            var workout = new TuesdayFridayWorkout();

            diet.GetFood();
            workout.GetWorkout();
        }
    }
}