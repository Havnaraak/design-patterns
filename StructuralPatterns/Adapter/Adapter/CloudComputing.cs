using Adapter.Adapter.Interfaces;

namespace Adapter.Adapter
{
    public class CloudComputing
    {
        IAdapter adapter;

        public CloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("processando CP");

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando CR");
        }
    }
}