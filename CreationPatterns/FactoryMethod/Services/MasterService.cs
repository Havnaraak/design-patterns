using System;

namespace FactoryMethod
{
    public class MasterService : IService
    {
        public MasterService()
        {
            Console.WriteLine("Serviço master criado com sucesso");
        }
        
        public void ExecuteServiceBilling()
        {
            // RN
        }
    }
}