using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<TModel> Get() => _connection.GetAll<TModel>();
        public TModel GetOnly(TModel model) => _connection.Get<TModel>(model);
        public void Create(TModel model) => _connection.Insert<TModel>(model);
        public void Update(TModel model) => _connection.Update<TModel>(model);
        public void Delete(TModel model) => _connection.Delete<TModel>(model);
    }
}