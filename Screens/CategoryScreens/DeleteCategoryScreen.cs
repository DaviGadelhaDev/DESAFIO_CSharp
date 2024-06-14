using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar perfil");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Delete(new Category{
                Id = id,
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(category);

                Console.WriteLine("Categoria excluida com sucesso");
            }catch(Exception e)
            {
                Console.WriteLine("Não foi possível excluir a categoria");
                Console.WriteLine(e.Message);
            }
        }
    }
}