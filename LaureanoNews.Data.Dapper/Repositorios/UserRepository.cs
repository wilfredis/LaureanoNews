using Dapper;
using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public class UserRepository : IUserRepository
    {
        private string ConnectionString;
        public UserRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public Task<IEnumerable<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserDetails(string email)
        {
            var db = dbConnection();

            var sql = "select Id,UserName,Email from AspNetUsers where Email = @Email";

            return await db.QueryFirstOrDefaultAsync<User>(sql.ToString(), new { Email = email });
        }
    }
}
