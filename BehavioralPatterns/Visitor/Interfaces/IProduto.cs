namespace Visitor.Interfaces
{
    public interface IProduto
    {
        public string Nome { get; set; }

        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor);
    }
}