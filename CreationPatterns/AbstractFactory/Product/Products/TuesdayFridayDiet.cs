using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class TuesdayFridayDiet : IDiet
    {
        public void GetFood()
        {
            Console.Write("TuesdayFridayDiet");
        }
    }
}