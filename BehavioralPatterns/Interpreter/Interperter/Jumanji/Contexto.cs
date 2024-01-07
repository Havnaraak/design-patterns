using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interpreter.Interperter.Jumanji
{
    public class Contexto
    {
        public Contexto(string personagem)
        {
            Personagem = personagem;
            Conteudo = string.Empty;
        }
        public string Personagem { get; set; }
        public string Conteudo { get; set; }
    }
}