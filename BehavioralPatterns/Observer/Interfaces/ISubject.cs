namespace Observer.Interfaces
{
    public interface ISubject
    {
        List<IObservavel> Observaveis {get; set;}

        void AddObservavel(IObservavel observavel);

        void RemoveObservavel(IObservavel observavel);

        void NotificarObservavel();
    }
}