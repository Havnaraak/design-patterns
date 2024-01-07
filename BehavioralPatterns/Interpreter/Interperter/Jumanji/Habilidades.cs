using Interpreter.Interperter.Jumanji.Interfaces;
using Interpreter.Interperter.Jumanji.MooseFinbar.PontosFortes;
using Interpreter.Interperter.Jumanji.MooseFinbar.PontosFracos;

namespace Interpreter.Interperter.Jumanji
{
    public class Habilidades : IExpressao
    {
        private List<IPontoForte> _pontosFortes;
        private List<IPontoFraco> _pontosFracos;

        public Habilidades(List<IPontoForte> pontosFortes, List<IPontoFraco> pontosFracos)
        {
            _pontosFortes = pontosFortes;
            _pontosFracos = pontosFracos;
        }

        public void Interpretar(Contexto contexto)
        {
            Console.WriteLine($"Personagem: {contexto.Personagem}");

            contexto.Conteudo += "Exibindo habilidades.. PontosFortes:";
            foreach (var ponto in _pontosFortes)
            {
                ponto.Interpretar(contexto);
            }

            contexto.Conteudo += "Pontos Fracos";
            foreach (var ponto in _pontosFracos)
            {
                ponto.Interpretar(contexto);
            }

            Console.WriteLine(contexto.Conteudo);
        }
    }
}