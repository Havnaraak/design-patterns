namespace TemplateMethod.Model
{
    public class Acoes
    {
        public Acoes()
        {
            
        }

        public Acoes(string sigla, int quantidade, double valorUnitario)
        {
            Sigla = sigla;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public string Sigla { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}