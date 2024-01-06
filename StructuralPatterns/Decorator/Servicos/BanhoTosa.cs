using Decorator.Interfaces;

namespace Decorator.Servicos
{
    public class BanhoTosa : IPet
    {
        private string _nomeServico;
        private double _valorServico;


        public BanhoTosa(string nomeServico, double valorServico)
        {
            _nomeServico = nomeServico;
            _valorServico = valorServico;
        }

        public string GetNomeServico()
        {
            return _nomeServico;
        }

        public double GetValorServico()
        {
            return _valorServico;
        }
    }
}