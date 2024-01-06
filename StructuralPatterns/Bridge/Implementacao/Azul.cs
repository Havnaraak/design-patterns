using Bridge.Implementacao.Interfaces;

namespace Bridge.Implementacao
{
    public class Azul : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            // Logica de buscar no banco por cor
            var quantidade = new Random().Next(100, 500);

            return $"{quantidade} para {tipoAbstracao} da cor azul";
        }
    }
}