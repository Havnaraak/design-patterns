using State.Interfaces;

namespace State.Estados
{
    public class EstadoA : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado A");
            context.Estado = new EstadoB();
        }
    }
}
