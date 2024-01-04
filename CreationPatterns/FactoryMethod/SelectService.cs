namespace FactoryMethod
{
    public class SelectService : ServiceFactory
    {
        public override IService CreateService(ServiceTypesEnum serviceTypes)
        {
            switch (serviceTypes)
            {
                case ServiceTypesEnum.Traditional:
                    return new TraditionalService();
                case ServiceTypesEnum.Premium:
                    return new PremiumService();
                case ServiceTypesEnum.Master:
                    return new MasterService();
                default:
                    return new TraditionalService();
            }
        }
    }
}