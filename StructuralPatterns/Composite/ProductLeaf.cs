using Composite.Model;

namespace Composite
{
    public class ProductLeaf : ComponentModel
    {
        private string _nome;
        private double _valor;


        public ProductLeaf(string nome, double valor)
        {
            _nome = nome;
            _valor = valor;
        }

        public override void Add(params ComponentModel[] components)
        {
            Console.WriteLine("Não é possivel adicionar obj em Leaf");
        }

        public override ComponentModel GetChild(int index)
        {
            Console.WriteLine("Não é possivel obter obj em Leaf");
            return null;
        }

        public override double Operation()
        {
            Console.WriteLine($"Produto: {_nome} Valor: {_valor}");

            return _valor;
        }

        public override void Remove(ComponentModel component)
        {
            Console.WriteLine("Não é possivel remover obj em Leaf");
        }
    }
}