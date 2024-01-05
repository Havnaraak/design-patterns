using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class TuesdayFridayWorkout : IWorkout
    {
        public void GetWorkout()
        {
            Console.WriteLine("TuesdayFridayWorkout");
        }
    }
}