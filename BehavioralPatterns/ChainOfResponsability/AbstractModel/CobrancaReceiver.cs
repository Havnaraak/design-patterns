namespace ChainOfResponsability.AbstractModel
{
    public abstract class CobrancaReceiver
    {
        public CobrancaReceiver Next = null;

        public CobrancaReceiver AddNext(CobrancaReceiver next)
        {
            this.Next = next;
            return next;
        }

        public virtual Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            if(this.Next != null)
                return this.Next.ExecutarCobrancaServico(checkout);

            return null;
        }
    }
}
