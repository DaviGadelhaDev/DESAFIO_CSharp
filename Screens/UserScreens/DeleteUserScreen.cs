using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreen;

namespace Blog.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        { 
            Console.Clear();
            Console.WriteLine("Excluir usuário");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);

            Delete(new User{
                Id = id
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(User user)
        {
            try{
                var repositoy = new Repository<User>(Database.Connection);
                repositoy.Delete(user);
                Console.WriteLine("Usuário excluido com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possível excluir este usuário");
                Console.WriteLine(e.Message);
            }
        }
    }
}