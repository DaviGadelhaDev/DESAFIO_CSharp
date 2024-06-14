using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ProfileScrens
{
    public class CreateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo perfil");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Create(new Profile{
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        public static void Create(Profile profile)
        {
            try
            {
                var repository = new Repository<Profile>(Database.Connection);
                repository.Create(profile);

                Console.WriteLine("Perfil cadastrado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel cadastrar o perfil");
                Console.WriteLine(e.Message);
            }
        }
    }
}