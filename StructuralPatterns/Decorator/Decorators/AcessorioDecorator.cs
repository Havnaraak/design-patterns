using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet)
        {
        }

        public override double GetValorServico()
        {
            return base.GetValorServico() + 30;
        }

        public override string GetNomeServico()
        {
            return base.GetNomeServico() + " Acessorio";
        }
    }
}