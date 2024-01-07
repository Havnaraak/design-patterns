namespace Iterator.Interfaces
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int index] { set; get; }
        public int Limit { get; }
    }
}
