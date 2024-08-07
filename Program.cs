namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnection sqlConnection = DBConnection.GetInstance();
            sqlConnection.OpenConnection();
        }
    }
}
