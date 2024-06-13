using Microsoft.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Dapper;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;
        public UserRepository(SqlConnection connection)
            :base(connection)
        {
            _connection = connection;
        }

        public List<User> GetUserWithProfiles()
        {
            var query = @"
            SELECT
                [User].*,
                [Profile].*
            FROM
                [User]
                LEFT JOIN [UserProfile] ON [UserProfile].[UserId] = [User].[Id]
                LEFT JOIN [Profile] ON [UserProfile].[ProfileId] = [Profile].[Id]
            ";
            var users = new List<User>();
            var items = _connection.Query<User, Profile, User>(query,
            (user, profile) => 
            {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);
                if(usr == null)
                {
                    usr = user;
                    if(profile != null)
                        usr.Profiles.Add(profile);

                    users.Add(usr);
                }
                else
                    usr.Profiles.Add(profile);

                return user;
            }, splitOn: "Id");
            return users;
        }
    }
}