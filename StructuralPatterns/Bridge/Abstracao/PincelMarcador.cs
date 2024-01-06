using Bridge.Abstracao.Interfaces;
using Bridge.Implementacao.Interfaces;

namespace Bridge.Abstracao
{
    public class PincelMarcador : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarEstoque()
        {
            return CorImplementacao.ConsultarQuantidadePorCor("Pincel");
        }
    }
}