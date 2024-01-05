using AbstractFactory.Creation.Interfaces;
using AbstractFactory.Product.Products;

namespace AbstractFactory.Creation.Factories
{
    public class MondayThursdayFactory : IFactory
    {
        public MondayThursdayFactory()
        {
            GetDailyRoutine();
        }

        public void GetDailyRoutine()
        {
            Console.WriteLine("MondayThursdayFactory");
            var diet = new MondayThursdayDiet();
            var workout = new MondayThursdayWorkout();

            diet.GetFood();
            workout.GetWorkout();
        }
    }
}