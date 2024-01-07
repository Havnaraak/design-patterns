using Observer.Interfaces;

namespace Observer.Subjects
{
    public class PrimeVideos : ISubject
    {
        public List<IObservavel> Observaveis { get; set; }

        public PrimeVideos()
        {
            Observaveis = new();
        }

        public void AddObservavel(IObservavel observavel)
        {
            Observaveis.Add(observavel);
        }

        public void NotificarObservavel()
        {
            foreach (var observavel in Observaveis)
            {
                observavel.Update();
            }
        }

        public void RemoveObservavel(IObservavel observavel)
        {
            Observaveis.Remove(observavel);
        }
    }
}