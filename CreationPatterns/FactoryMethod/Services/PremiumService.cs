using System;

namespace FactoryMethod
{
    public class PremiumService : IService
    {
        public PremiumService()
        {
            Console.WriteLine("Serviço Premium criado com sucesso");
        }
        public void ExecuteServiceBilling()
        {
            // RN
        }
    }
}