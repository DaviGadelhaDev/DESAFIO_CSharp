using Blog.Screens.UserScreens;
using DESAFIO.Screens.UserScreens;

namespace Blog.Screens.UserScreen
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuário");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Cadastrar usuário");
            Console.WriteLine("3 - Editar usuário");
            Console.WriteLine("4 - Excluir usuário");
            Console.WriteLine();

            short res = short.Parse(Console.ReadLine()!);
            switch(res)
            {
                case 1:
                    ListUserScreen.Load();
                break;
                case 2:
                    CreateUserScreen.Load();
                break;
                case 3:
                    UpdateUserScreen.Load();
                break;
                case 4:
                    DeleteUserScreen.Load();
                break;
                default:{
                    Console.WriteLine("Digite um valor válido");
                    Thread.Sleep(1500);
                    Load();
                    break;
                }
            }
        }
    }
}