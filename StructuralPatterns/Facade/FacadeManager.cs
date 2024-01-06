using Facade.AmbienteComplexo;

namespace Facade
{
    public class FacadeManager
    {
        public void ExecutarComplexidade()
        {
            var zonaNorte = new ZonaNorte();
            var zonaSul = new ZonaSul();
            var cloudComputing = new CloudComputing();

            var sul = zonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);
            var norte = zonaNorte.ExecutaRotinaVendasPerdidas(DateTime.Now);

            cloudComputing.GerarRelatorioPerdasGanhos(sul, norte);
        }
    }
}