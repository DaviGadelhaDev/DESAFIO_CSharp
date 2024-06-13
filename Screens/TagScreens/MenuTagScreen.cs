using Microsoft.Data.SqlClient;

namespace Blog.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar Tag");
            Console.WriteLine("3 - Editar Tag");
            Console.WriteLine("4 - Excluir Tag");
            Console.WriteLine();

            short res = short.Parse(Console.ReadLine() !);
            switch(res)
            {
                case 1:
                    ListTagScreen.Load();
                break;
                case 2:
                    CreateTagScreen.Load();
                break;
                case 3:
                    UpdateTagScreen.Load();
                break;
                case 4:
                    DeleteTagScreen.Load();
                break;
                default:
                    Load(); break;
            }
        }
    }
}