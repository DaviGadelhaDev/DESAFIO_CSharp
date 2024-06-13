
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
         public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o ID da tag para excluir? ");
            int id = int.Parse(Console.ReadLine()!);
            Delete(new Tag{
                Id = id,
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(tag);
                Console.WriteLine("Tag excluida com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel excluir a tag");
                Console.WriteLine(e.Message);
            }
        }
    }
}