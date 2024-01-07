using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visitor.Interfaces;
using Visitor.Produtos;

namespace Visitor.Visitors
{
    public class RioDeJaneiroVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 5;
            Console.WriteLine("Imposto RJ");
            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 10;
            Console.WriteLine("Imposto RJ");
            return imposto;
        }
    }
}