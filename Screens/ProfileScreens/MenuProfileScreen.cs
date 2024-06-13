namespace Blog.Screens.Profile
{
    public class MenuProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Perfil");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar perfil");
            Console.WriteLine("2 - Cadastrar perfil");
            Console.WriteLine("3 - Editar perfil");
            Console.WriteLine("4 - Excluir perfil");
            Console.WriteLine();

            short res = short.Parse(Console.ReadLine()!);
            switch(res)
            {
                //
            }
        }
    }
}