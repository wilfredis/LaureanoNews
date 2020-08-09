using Dapper;
using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public class RolRepository : IRolRepository
    {
        private string ConnectionString;

        public RolRepository(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<IEnumerable<Rol>> GetAllRols()
        {
            var db = dbConnection();

            var sql = "select * from AspNetRoles";

            return await db.QueryAsync<Rol>(sql.ToString(), new { });
        }

        public async Task<bool> InsertRol(Rol rol)
        {
            var db = dbConnection();
            var sql = "insert into AspNetRoles(Id,Name) values(@ID,@Name)";

            var result = await db.ExecuteAsync(sql.ToString(),
               new { rol.Id,rol.Name });
            return result > 0;
        }

        public async Task<int> GetLastId()
        {
            var db = dbConnection();

            var sql = "select  max(id)Id from AspNetRoles";
               

            return await db.QueryFirstOrDefaultAsync<int>(sql.ToString(), new {  });
        }

       

       
    }
}
