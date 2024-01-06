using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public abstract class PetDecorator : IPet
    {
        protected IPet _pet;

        protected PetDecorator(IPet pet)
        {
            _pet = pet;
        }

        public virtual string GetNomeServico()
        {
            return _pet.GetNomeServico();
        }

        public virtual double GetValorServico()
        {
            return _pet.GetValorServico();
        }
    }
}