using System;

namespace FactoryMethod
{
    public class TraditionalService : IService
    {
        public TraditionalService()
        {
            Console.WriteLine("Serviço master criado com sucesso");
        }

        public void ExecuteServiceBilling()
        {
            // RN
        }
    }
}