using System;

namespace FactoryMethod
{
    public class Client
    {
        public void ExecuteCreateService()
        {
            var selectService = new SelectService();

            while (true)
            {
                Console.WriteLine("Selecione o tipo de serviço: \n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");

                Console.Write("Digite o número do serviço que irá cobrar: ");
                var serviceType = Convert.ToInt32(Console.ReadLine());


                var service = 
                    selectService.CreateService((ServiceTypesEnum)serviceType);
                
                break;
            }
        }
    }
}