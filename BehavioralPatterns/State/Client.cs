using State.Estados;

namespace State
{
    public class Client
    {
        public void ExecutarContext()
        {
            Context context = new Context(new EstadoA());

            context.Trocar();
            context.Trocar();

        }
    }
}
