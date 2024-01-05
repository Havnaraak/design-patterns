using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class WednesdaySaturdayDiet : IDiet
    {
        public void GetFood()
        {
            Console.WriteLine("WednesdaySaturdayDiet");
        }
    }
}