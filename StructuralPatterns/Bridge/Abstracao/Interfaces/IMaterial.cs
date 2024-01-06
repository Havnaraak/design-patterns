using Bridge.Implementacao.Interfaces;

namespace Bridge.Abstracao.Interfaces
{
    public interface IMaterial
    {
        public ICor CorImplementacao { get; set; }

        string ConsultarEstoque();
    }
}