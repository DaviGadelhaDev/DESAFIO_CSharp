using Blog.Repositories;
using Blog.Models;
using Blog.Screens.ProfileScrens;

namespace Blog.Screens.CategoryScreen
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();

            foreach(var category in categories)
                Console.WriteLine(category.Name);
        }
    }
}