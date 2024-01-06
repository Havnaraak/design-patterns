using System.Xml.Serialization;
using Newtonsoft.Json;
using TemplateMethod.Model;

namespace TemplateMethod
{
    public class ObtemDadosAPI
    {
        public static string EndPointXML()
        {
            var pessoas = GetPessoas();
            var serializer = new XmlSerializer(pessoas.GetType());
            var xml = String.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }
            
            return xml;
        }
        public static string EndPointJSON()
        {
            var pessoas = GetPessoas();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa() {
                    Nome = "José",
                    CPF = "12345",
                    Acoes =  new List<Acoes>(){
                        new Acoes("AAA", 50, 15),
                        new Acoes("BBB", 60, 20)
                    }
                },
                new Pessoa() {
                    Nome = "Pedro",
                    CPF = "123456",
                    Acoes =  new List<Acoes>(){
                        new Acoes("AAA", 50, 15),
                        new Acoes("BBB", 60, 20)
                    }
                },
            };
        }
    }
}