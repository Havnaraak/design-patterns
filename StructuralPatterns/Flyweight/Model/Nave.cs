namespace Flyweight.Model
{
    public abstract class Nave
    {
        protected string? Condicao;
        protected string? Acao;

        public string? Cor { get; set; }
        public string? Tamanho { get; set; }

        public abstract void Exibir(string cor, string tamanho);
    }
}