using Composite.Model;

namespace Composite
{
    public class Client
    {
        public void EfeturaCompra()
        {
            ComponentModel product01 = new ProductLeaf("Cubo", 10);
            ComponentModel product02 = new ProductLeaf("Triangulo", 10);
            ComponentModel product03 = new ProductLeaf("Retangulo", 10);

            ComponentModel smllBox = new ProductComposite();
            smllBox.Add(product01, product03, product02);

            ComponentModel bgBox = new ProductComposite();

            bgBox.Add(smllBox, product03);

            var valorTotal = bgBox.Operation();
            Console.WriteLine(valorTotal);
        }
    }
}