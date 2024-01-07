using State.Interfaces;

namespace State
{
    public class Context
    {
        private IEstado _estado;

        public Context(IEstado estado)
        {
            _estado = estado;
        }

        public IEstado Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine($"Mudando para {_estado.GetType().Name}");
            }
        }

        public void Trocar()
        {
            _estado.Acao(this);
        }

    }
}
