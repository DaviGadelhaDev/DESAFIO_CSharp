using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.ProfileScrens
{
    public class ListProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Perfis");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuProfileScreen.Load();
        }
        public static void List()
        {
            var repository = new Repository<Profile>(Database.Connection);
            var profiles = repository.Get();

            foreach(var profile in profiles)
                Console.WriteLine(profile.Name);
        }
    }
}