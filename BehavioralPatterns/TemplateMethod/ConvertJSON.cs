using Newtonsoft.Json;
using TemplateMethod.AbstractModel;
using TemplateMethod.Model;

namespace TemplateMethod
{
    public class ConvertJSON : ProcessaDados
    {
        public ConvertJSON(string json) : base(json:json)
        {
        }

        public override void ProcessarJSON()
        {
            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(json);
            ApresentarValores();
        }
    }
}