using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product.Products
{
    public class MondayThursdayDiet : IDiet
    {
        public void GetFood()
        {
            Console.Write("MondayThursdayDiet");
        }
    }
}