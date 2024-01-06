using Decorator.Decorators;
using Decorator.Interfaces;
using Decorator.Servicos;

namespace Decorator
{
    public class Client
    {
        public void ConsumirServicos()
        {
            IPet banhoTosa = new BanhoTosa("banhoTosa", 40);

            IPet acessorioDecorator = new AcessorioDecorator(banhoTosa);
            IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecorator);

            Console.WriteLine("Resumo");
            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine(luxoSpaDecorator.GetValorServico());
        }
    }
}