using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Editar tag");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Update(new Tag{
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel atualizar a tag");
                Console.WriteLine(e.Message);
            }
        }
    }
}