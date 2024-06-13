using Blog.Screens.UserScreen;
using Blog.Models;
using Blog.Repositories;
using Blog;

namespace DESAFIO.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("-------------");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine()!);
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

            UpdateUser(new User{
                Id = id,
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
        public static void UpdateUser(User user)
        {
            try{
                var repository = new UserRepository(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso");

            }catch(Exception e)
            {
                Console.WriteLine("Não foi possivel atualizar o usuário");
                Console.WriteLine(e.Message);
            }
        }
    }
}