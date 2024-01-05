using AbstractFactory.Creation.Factories;
using AbstractFactory.Creation.Interfaces;

namespace AbstractFactory
{
    public class Client
    {
        public void GetStudentRoutine()
        {
            IFactory factory;

            Console.WriteLine("Select routine");
            Console.WriteLine("1 -> MondayThursday");
            Console.WriteLine("2 -> TuesdayFriday");
            Console.WriteLine("3 -> WednesdaySaturday");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    factory = new MondayThursdayFactory();
                    break;
                case "2":
                    factory = new TuesdayFridayFactory();
                    break;
                case "3":
                    factory = new WednesdaySaturdayFactory();
                    break;
                default:
                    break;
            }
        }
    }
}