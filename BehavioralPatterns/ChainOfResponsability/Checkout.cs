namespace ChainOfResponsability
{
    public class Checkout
    {
        public Checkout(int clienteId, int quantidadeDias, double valorDiaria)
        {
            ClienteId = clienteId;
            QuantidadeDias = quantidadeDias;
            ValorDiaria = valorDiaria;
            CalcularTotal();
        }

        public int ClienteId { get; set; }
        public int QuantidadeDias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotal { get; set; }

        private void CalcularTotal()
        {
            this.ValorTotal = this.QuantidadeDias * this.ValorDiaria;
        }
    }
}
