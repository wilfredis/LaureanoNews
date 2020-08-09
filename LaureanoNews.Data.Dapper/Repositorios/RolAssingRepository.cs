using Dapper;
using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
namespace LaureanoNews.Data.Dapper.Repositorios
{
    public class RolAssingRepository : IRolAssingRepository
    {
        private string ConnectionString;

        public RolAssingRepository(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<IEnumerable<RolAssing>> GetAllUserRols()
        {
            var db = dbConnection();

            var sql = "select U.DI,U.Id IdUsuario,U.UserName,R.Id ,R.Name from AspNetUserRoles UR join AspNetRoles R " +
                "on UR.RoleId = R.Id right join AspNetUsers U on U.Id = UR.UserId";
            return await db.QueryAsync<RolAssing>(sql.ToString(), new { });
        }

        public async Task <RolAssing> GetUserRols(int di)
        {
            var db = dbConnection();

            var sql = "select U.DI,U.Id IdUsuario,U.UserName,R.Id ,R.Name from AspNetUserRoles UR join AspNetRoles R " +
                "on UR.RoleId = R.Id right join AspNetUsers U on U.Id = UR.UserId   where U.DI = @DI";
            return await db.QueryFirstOrDefaultAsync<RolAssing>(sql.ToString(), new { DI = di });
        }

        public async Task<bool> InsertUserRols(string us, int rol)
        {
            var db = dbConnection();

            var sql = "insert into AspNetUserRoles(UserId,RoleId) values(@UserId,@RoleId)";

            var result = await db.ExecuteAsync(sql.ToString(),
               new { UserId = us, RoleId = rol });
            return result > 0;
        }

        public async Task<bool> UpdateUserRols(string us, int rol)
        {
            var db = dbConnection();

            var sql = "update AspNetUserRoles set RoleId = @RoleId where UserId = @UserId ";

            var result = await db.ExecuteAsync(sql.ToString(),
               new { UserId =us,RoleId= rol });
            return result > 0;
        }
    }
}
