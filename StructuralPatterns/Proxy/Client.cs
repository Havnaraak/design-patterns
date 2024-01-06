using Proxy.Model;

namespace Proxy
{
    public class Client
    {
        public void ConectarClientVPN()
        {
            var proxy = new VPNProxy();

            string username = "José";
            string password = "1234";

            var user = new User(username, password);
            proxy.AcessarVPN(user);
        }
    }
}