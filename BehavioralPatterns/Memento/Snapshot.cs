namespace Memento
{
    public class Snapshot
    {
        private string _estado;

        public Snapshot(string estado)
        {
            _estado = estado;
        }

        public string GetState()
        {
            return _estado;
        }

    }
}
