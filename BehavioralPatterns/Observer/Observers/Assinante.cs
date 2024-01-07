using Observer.Interfaces;
using Observer.Model;

namespace Observer.Observers
{
    public class Assinante : IObservavel
    {
        public Assinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }

        public string Mensagem { get; set; }

        public void Update()
        {
            // Simula enivo de email ao assinante
            Console.WriteLine($"Enviando Email para {Pessoa.Email}");
            Console.WriteLine(Mensagem);
        }
    }
}