using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class WednesdaySaturdayWorkout : IWorkout
    {
        public void GetWorkout()
        {
            Console.WriteLine("WednesdaySaturdayWorkout");
        }
    }
}