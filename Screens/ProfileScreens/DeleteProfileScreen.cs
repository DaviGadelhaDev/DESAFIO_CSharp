using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ProfileScrens
{
    public class DeleteProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir perfil");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);

            Delete(new Profile{
                Id = id
            });
            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        public static void Delete(Profile profile)
        {
            try
            {
                var repository = new Repository<Profile>(Database.Connection);
                repository.Delete(profile);
                Console.WriteLine("Perfil excluido com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possível excluir o perfil");
                Console.WriteLine(e.Message);
            }
        }
    }
}