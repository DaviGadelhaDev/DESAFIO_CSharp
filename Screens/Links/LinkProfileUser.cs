using Blog.Models;
using Dapper;

namespace Blog.Screens.Links
{
    public class LinkProfileUser
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular um perfil a um usuário");
            Console.WriteLine("--------------");
            
            Console.WriteLine();

            Link();
            Console.ReadKey();
            IndexScreen.Load();
        }

        public static void Link()
        {
            var connection = Database.Connection;

            Console.Clear();
            Console.WriteLine("Digite o ID do perfil: ");
            int profileId = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o ID do usuário: ");
            int userId = int.Parse(Console.ReadLine()!);

            var user = new User();
            user.Id = userId;
            var profile = new Profile();
            profile.Id = profileId;

            var query = @"
                INSERT INTO [UserProfile] VALUES(@UserId, @ProfileId)
            ";

            var rows = connection.Execute(query, new 
            {
                UserId = user.Id,
                ProfileId = profile.Id
            });
            Console.WriteLine($"{rows} linhas inseridas");
        }
    }
}