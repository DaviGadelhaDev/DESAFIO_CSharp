using Microsoft.Data.SqlClient;

namespace Blog
{
    //static fica sempre na memória
    public static class Database
    {
        public readonly static SqlConnection Connection;
    }
}