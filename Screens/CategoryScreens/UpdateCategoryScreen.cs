using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;
            Update(new Category{
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category )
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);

                Console.WriteLine("Categoria atualizada com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel atualizar a categoria");
                Console.WriteLine(e.Message);
            }
        }
    }
}