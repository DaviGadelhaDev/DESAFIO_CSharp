using Blog.Screens.CategoryScreen;
using Blog.Screens.ProfileScrens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreen;
using Blog.Screens.Links;

namespace Blog.Screens
{
    public class IndexScreen
    {
        public static void Load()
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
            Console.WriteLine();


            short res = short.Parse(Console.ReadLine()!);
            
            switch(res)
            {
                case 1:
                    MenuUserScreen.Load();
                break;
                case 2:
                    MenuProfileScreen.Load();
                break;
                case 3:
                    MenuCategoryScreen.Load();
                break;
                case 4:
                    MenuTagScreen.Load(); break;
                case 5:
                    LinkProfileUser.Load();
                break;
                case 6:
                    //MenuPostTagScreen.Load();
                break;
                default:
                    Load(); break;
            }
        }
    }
}