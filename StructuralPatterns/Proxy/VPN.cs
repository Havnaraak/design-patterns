using Proxy.Interfaces;
using Proxy.Model;

namespace Proxy
{
    public class VPN : IProxy
    {

        public void AcessarVPN(User user)
        {
            Console.WriteLine("Acessando VPN");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.Name} logado na VPN");
        }
    }
}