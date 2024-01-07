using Strategy.Interfaces;
using Strategy.Model;

namespace Strategy.Servicos
{
    public class MasterServico : IServico
    {
        private Orcamento _orcamento;

        public MasterServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.CupomDesconto && _orcamento.Quantidade > 60)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;
                Console.WriteLine($"Conta superior a 60 e cupom de desconto recebe 3% de desconto para suíte Master.\n");
            }
            else
            if (_orcamento.CupomDesconto)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;
                Console.WriteLine($"Cupom de desconto de 2% para suíte Master.\n");
            }

            Console.WriteLine($"Tipo Quarto: {_orcamento.Porcentagem}\nPorcentagem Serviço: {porcentagem.ToString("C")}\nQuant. Dias: {_orcamento.Quantidade}\nValor Dia: {_orcamento.ValorDiaria}\n Valor Total: {_orcamento.ValorTotal}");
        }
    }
}
