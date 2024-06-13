using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreen;

namespace Blog.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine()!;

            Console.WriteLine("Email: ");
            string email = Console.ReadLine()!;

            Console.WriteLine("Password: ");
            string password = Console.ReadLine()!;

            Console.WriteLine("Bio: ");
            string bio = Console.ReadLine()!;

            Console.WriteLine("Image: ");
            string image = Console.ReadLine()!;

            Console.WriteLine("Slug: ");
            string slug = Console.ReadLine()!;

            CreateUser(new User{
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void CreateUser(User user)
        {
            try{
                var repository = new UserRepository(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso");

            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel cadastrar o usuário");
                Console.WriteLine(e.Message);
            }
        }
    }
}