using TemplateMethod.Model;

namespace TemplateMethod.AbstractModel
{
    public abstract class ProcessaDados
    {
        protected List<Pessoa> pessoas;
        protected string json;
        protected string xml;

        public ProcessaDados(string xml = "", string json = "")
        {
            if (!String.IsNullOrEmpty(xml))
                this.xml = xml;
            else if (!String.IsNullOrEmpty(json))
                this.json = json;

            pessoas = new List<Pessoa>();
        }

        public virtual void ProcessarXML() { }
        public virtual void ProcessarJSON() { }

        protected void ApresentarValores()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Cliente {pessoa.Nome}");
                double valorTotal = 0;

                foreach (var acao in pessoa.Acoes)
                {
                    valorTotal += acao.ValorUnitario * acao.Quantidade;
                    Console.WriteLine($"Sigla: {acao.Sigla}, ValorTotal = {valorTotal}");
                }
            }
        }
    }
}