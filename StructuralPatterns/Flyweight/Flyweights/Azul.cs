using Flyweight.Model;

namespace Flyweight.Flyweights
{
    public class Azul : Nave
    {
        public Azul()
        {
            Condicao = "Voando em linha reta";
            Acao = "Diparando";
        }

        public override void Exibir(string cor, string tamanho)
        {
            Cor = cor;
            Tamanho = tamanho;

            Console.WriteLine($"nave {Tamanho} e {Cor} {Condicao} {Acao}");
        }
    }
}