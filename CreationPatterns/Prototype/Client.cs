namespace Prototype
{
    public class Client
    {
        public void Consume()
        {
            var manager = new SalesManagerStudio();

            manager["24m"] = new Studio("24m", "AAA", 1000M);
            manager["26m"] = new Studio("26m", "BBB", 200M);

            var first = manager["24m"].Clone();
            var second = manager["26m"].Clone();
        }
    }
}