namespace Adapter.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);

            Console.WriteLine("ContasPagar");

            return result;
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);

            Console.WriteLine("ContasReceber");

            return result;
        }
    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("janeiro", "CPF:0000000000");
            dictionary.Add("Fevereiro", "CPF:0000000000");
            dictionary.Add("Marco", "CPF:0000000000");
            dictionary.Add("Abril", "CPF:0000000000");
            dictionary.Add("Maio", "CPF:0000000000");

            return dictionary[mes];
        }

        public static string GetDadosReceber(string mes)
        {
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("janeiro", "CPF:0000000000");
            dictionary.Add("Fevereiro", "CPF:0000000000");
            dictionary.Add("Marco", "CPF:0000000000");
            dictionary.Add("Abril", "CPF:0000000000");
            dictionary.Add("Maio", "CPF:0000000000");

            return dictionary[mes];
        }
    }
}