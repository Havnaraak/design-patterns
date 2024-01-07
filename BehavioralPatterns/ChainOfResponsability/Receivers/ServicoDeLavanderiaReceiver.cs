using ChainOfResponsability.AbstractModel;

namespace ChainOfResponsability.Receivers
{
    public class ServicoDeLavanderiaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança taxa de serviços de lavanderia...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.028);

            return base.ExecutarCobrancaServico(checkout);
        }

    }
}
