using Microsoft.Data.SqlClient;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreen;
using Blog.Screens;


namespace Blog
{
    class Program
    { 
        private const string connectionString = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            using(Database.Connection = new SqlConnection(connectionString))
            {
                Database.Connection.Open();

                IndexScreen.Load();

                Console.ReadKey();
                Database.Connection.Close();
            }
        }
        
    }
}