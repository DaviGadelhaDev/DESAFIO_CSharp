using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ProfileScrens
{
    public class UpdateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar perfil");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Update(new Profile{
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        public static void Update(Profile profile)
        {
            try
            {
                var repository = new Repository<Profile>(Database.Connection);
                repository.Update(profile);

                Console.WriteLine("Perfil atualizado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possível atualizar o perfil");
                Console.WriteLine(e.Message);
            }
        }
    }
}