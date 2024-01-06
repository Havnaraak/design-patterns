using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class LuxoSpaDecorator : PetDecorator
    {
        public LuxoSpaDecorator(IPet pet) : base(pet)
        {
        }

        public override double GetValorServico()
        {
            return base.GetValorServico() + 200;
        }

        public override string GetNomeServico()
        {
            return base.GetNomeServico() + " Luxo Spa";
        }
    }
}