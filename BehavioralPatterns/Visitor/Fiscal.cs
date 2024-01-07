using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visitor.Interfaces;
using Visitor.Produtos;
using Visitor.Visitors;

namespace Visitor
{
    public class Fiscal
    {
        public void CalcularImpostos()
        {
            CalcularProdutosNaoPereciveis();
            CalcularProdutosPereciveis();
        }

        private static void CalcularProdutosNaoPereciveis()
        {
            var produtosNaoPereciveis = new List<ProdutoNaoPerecivel>()
            {
                new ProdutoNaoPerecivel("controle", 10),
                new ProdutoNaoPerecivel("teclado", 20),
            };

            foreach (var pnp in produtosNaoPereciveis)
            {
                Console.WriteLine($"Produto {pnp.Nome}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoNaoPerecivel(pnp);
                }
            }
        }

        private static void CalcularProdutosPereciveis()
        {
            var produtosPereciveis = new List<ProdutoNaoPerecivel>()
            {
                new ProdutoNaoPerecivel("maionese", 10),
                new ProdutoNaoPerecivel("mostarda", 20),
            };

            foreach (var pp in produtosPereciveis)
            {
                Console.WriteLine($"Produto {pp.Nome}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoNaoPerecivel(pp);
                }
            }
        }


        private static List<IVisitor> GetVisitors() => new List<IVisitor>()
        {
            new RioDeJaneiroVisitor(),
            new SaoPauloVisitor(),
        };
    }
}