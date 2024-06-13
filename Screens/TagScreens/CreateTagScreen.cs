using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Create(new Tag{
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Create(Tag tag)
        {
            //Tratativa de erro caso o Slug já exista
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(e.Message);
            }
        }
    }
}