using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visitor.Interfaces;
using Visitor.Produtos;

namespace Visitor.Visitors
{
    public class SaoPauloVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 7;
            Console.WriteLine("Imposto SP");
            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 12;
            Console.WriteLine("Imposto SP");
            return imposto;
        }
    }
}