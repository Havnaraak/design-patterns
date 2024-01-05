namespace Singleton
{
    public class Client
    {
        public void ExecuteQuery()
        {
            var instance = ContextDb.Instance;

            instance.ExecuteQuery("SELECT * FROM Table_Name");

            instance = ContextDb.Instance;
            instance.ExecuteQuery("DELETE FROM Table_Name");

        }
    }
}