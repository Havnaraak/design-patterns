using Flyweight.Flyweights;
using Flyweight.Model;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Nave> listaNave = new();

        public Nave GetNave(string cor)
        {
            Nave nave = null;

            if (listaNave.ContainsKey(cor))
            {
                nave = listaNave[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        nave = new Azul();
                        break;
                    case "cinza":
                        nave = new Cinza();
                        break;
                    case "vermelha":
                        nave = new Vermelha();
                        break;
                }

                listaNave.Add(cor, nave);
            }

            return nave;
        }
    }
}