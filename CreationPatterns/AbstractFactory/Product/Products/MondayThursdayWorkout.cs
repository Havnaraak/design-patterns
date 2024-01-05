using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class MondayThursdayWorkout : IWorkout
    {
        public void GetWorkout()
        {
            Console.Write("MondayThursdayWorkout");
        }
    }
}