namespace Iterator.Interfaces
{
    public interface IIterator
    {
        string Next { get; }
        bool HasNext { get; }  
    }
}
