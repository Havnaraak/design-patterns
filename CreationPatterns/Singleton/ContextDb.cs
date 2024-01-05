namespace Singleton
{
    public class ContextDb
    {
        private static ContextDb? _instance;

        private ContextDb()
        {
        }

        public static ContextDb Instance
        {
            get
            {
                return _instance is null
                    ? new ContextDb()
                    : _instance;
            }
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine(query);
        }

    }
}