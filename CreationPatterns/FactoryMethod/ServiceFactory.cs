namespace FactoryMethod
{
    public abstract class ServiceFactory
    {
        // Método criador abstrato
        public abstract IService CreateService(ServiceTypesEnum serviceTypes);
    }
}