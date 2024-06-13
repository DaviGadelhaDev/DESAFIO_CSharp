using Microsoft.Data.SqlClient;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreen;


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

                Load();

                Console.ReadKey();
                Database.Connection.Close();
            }
        }
        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("--------");
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular Post/Tag");
            Console.WriteLine("7 - Relatórios"); //Listagens
            Console.WriteLine();

            short res = short.Parse(Console.ReadLine()!);

            switch(res)
            {
                case 1:
                    MenuUserScreen.Load();
                break;
                case 2:
                    //MenuProfileScreen.Load();
                break;
                case 3:
                    //MenuCategoryScreen.Load();
                break;
                case 4:
                    MenuTagScreen.Load(); break;
                case 5:
                    //MenuUserProfileScreen.Load();
                break;
                case 6:
                    //MenuPostTagScreen.Load();
                break;
                case 7:
                    //MenuReportsScreen.Load();
                break;
                default:
                    Load(); break;
            }
        }
    }
}