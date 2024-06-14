using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Create(new Category{
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category )
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);

                Console.WriteLine("Categoria cadastrado com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel cadastrar a categoria");
                Console.WriteLine(e.Message);
            }
        }
    }
}