namespace Flyweight
{
    public class Client
    {
        List<string> coresTamanhos = new List<string>(){
            "azul:pequena",
            "cinza:media",
            "vermelha:grande",
            "azul:pequena",
            "cinza:media",
            "vermelha:grande",
        };

        public void Consumir()
        {
            var factory = new FlyweightFactory();

            foreach (var item in coresTamanhos)
            {
                var cor = item.Split(":")[0];
                var tamanho = item.Split(":")[1];
                var nave = factory.GetNave(cor);

                nave.Exibir(cor, tamanho);
            }
        }
    }
}