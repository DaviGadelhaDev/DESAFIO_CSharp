using Blog.Repositories;
using Blog.Screens.UserScreen;

namespace Blog.Screens.UserScreens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void List()
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.GetUserWithProfiles();

            foreach(var user in users)
            {
                Console.WriteLine(user.Name);
                foreach(var profile in user.Profiles)
                    Console.WriteLine($" - {profile.Name}");
            }
        }
    }
}