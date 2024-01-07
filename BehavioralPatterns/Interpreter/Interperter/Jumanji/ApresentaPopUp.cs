using Interpreter.Interperter.Jumanji.MooseFinbar.PontosFortes;
using Interpreter.Interperter.Jumanji.MooseFinbar.PontosFracos;

namespace Interpreter.Interperter.Jumanji
{
    public class ApresentaPopUp
    {
        public void ApresentarHabilidadesPopup()
        {
            var pontosFortes = new List<IPontoForte>()
            {
                new Armeiro(), 
                new Zoologia(),
            };

            var pontosFracos = new List<IPontoFraco>() {
                new Bolo(),
                new Forca(),
                new Velocidade(),
            };

            var mooseFinbar = new Contexto("Moose Finbar");

            var habilidades = new Habilidades(pontosFortes, pontosFracos); 
            habilidades.Interpretar(mooseFinbar);
        }
    }
}