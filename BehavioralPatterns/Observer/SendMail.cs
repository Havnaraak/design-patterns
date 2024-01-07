using Observer.Interfaces;
using Observer.Model;
using Observer.Observers;
using Observer.Subjects;

namespace Observer
{
    public class SendMail
    {
        public void EnviarEmail()
        {
            var msgAindaNaoAssinante = "Faça parte da plataforma";

            var msgAssinante = "Novos lançamentos";

            var observaveis = new List<IObservavel>()
            {
                new NaoAssinante(new Pessoa(01, "José", "123@gmail."), msgAindaNaoAssinante),
                new Assinante(new Pessoa(2, "Pedro", "12345@gmail.com"), msgAssinante),
            };

            var primeVideos = new PrimeVideos();

            foreach (var o in observaveis)
            {
                primeVideos.AddObservavel(o);
            }

            primeVideos.NotificarObservavel();
        }
    }
}