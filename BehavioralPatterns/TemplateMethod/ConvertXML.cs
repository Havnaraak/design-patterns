using System.Xml;
using System.Xml.Serialization;
using TemplateMethod.AbstractModel;
using TemplateMethod.Model;

namespace TemplateMethod
{
    public class ConvertXML : ProcessaDados
    {
        public ConvertXML(string xml) : base(xml:xml)
        {
        }

        public override void ProcessarXML()
        {
            var serializer = new XmlSerializer(pessoas.GetType());

            var stringReader = new StringReader(xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                pessoas = (List<Pessoa>)serializer.Deserialize(reader);
            }

            ApresentarValores();
        }
    }
}