
using ChainOfResponsability.AbstractModel;


namespace ChainOfResponsability.Receivers
{
    public class ServicoLimpezaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando a cobrança de taxa de serviços de limpeza...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.025);

            return base.ExecutarCobrancaServico(checkout);
        }

    }
}
