using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethod.Model
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public string Nome { get; set; }
        public string CPF { get; set; }

        public List<Acoes> Acoes { get; set; }
    }
}