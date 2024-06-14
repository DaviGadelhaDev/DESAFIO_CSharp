namespace Blog.Screens.CategoryScreen
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categorias");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Cadastrar categoria");
            Console.WriteLine("3 - Editar categoria");
            Console.WriteLine("4 - Excluir categoria");
            Console.WriteLine();

            short res = short.Parse(Console.ReadLine()!);
            switch(res)
            {
                case 1: 
                    ListCategoryScreen.Load();
                break;
                case 2: 
                    CreateCategoryScreen.Load();
                break;
                case 3: 
                    UpdateCategoryScreen.Load();
                break;
                case 4: 
                    DeleteCategoryScreen.Load();
                break;
                default: 
                    Load();
                break;
            }
        }
    }
}