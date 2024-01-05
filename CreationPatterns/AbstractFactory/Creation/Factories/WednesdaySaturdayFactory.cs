using AbstractFactory.Creation.Interfaces;
using AbstractFactory.Product.Products;

namespace AbstractFactory.Creation.Factories
{
    public class WednesdaySaturdayFactory : IFactory
    {
        public WednesdaySaturdayFactory()
        {
            GetDailyRoutine();
        }

        public void GetDailyRoutine()
        {
            Console.WriteLine("TuesdayFridayFactory");
            var diet = new WednesdaySaturdayDiet();
            var workout = new WednesdaySaturdayWorkout();

            diet.GetFood();
            workout.GetWorkout();
        }
    }
}