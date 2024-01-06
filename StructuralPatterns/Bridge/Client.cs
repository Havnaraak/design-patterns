using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bridge.Abstracao.Interfaces;

namespace Bridge
{
    public class Client
    {
        public IMaterial Material { get; set; }

        public void ConsultarCanetasPinceisNoEstoque()
        {
            Console.WriteLine(Material.ConsultarEstoque());
        }
    }
}