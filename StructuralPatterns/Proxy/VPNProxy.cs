using Proxy.Interfaces;
using Proxy.Model;
using Proxy.SQL;

namespace Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            var sql = new DataBaseConnection();
            sql.RegistrarAcessoVPN(user);

            var vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}