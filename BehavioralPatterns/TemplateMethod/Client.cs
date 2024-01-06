namespace TemplateMethod
{
    public class Client
    {
        public void ConsumirEndpointXml()
        {
            Console.WriteLine("XML");
            var xml = ObtemDadosAPI.EndPointXML();

            var convertXMl = new ConvertXML(xml);

            convertXMl.ProcessarXML();
        }


        public void ConsumirEndpointJson()
        {
            Console.WriteLine("JSON");
            var json = ObtemDadosAPI.EndPointJSON();

            var convertJSON = new ConvertJSON(json);

            convertJSON.ProcessarJSON();
        }
    }
}