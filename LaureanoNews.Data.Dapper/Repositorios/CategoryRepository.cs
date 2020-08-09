using Dapper;
using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public class CategoryRepository : ICategoryRepository
    {
        private string ConnectionString;

        public CategoryRepository(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<IEnumerable<Categoria>> GetAllCategory()
        {
            var db = dbConnection();

            var sql = "select id,nombre from Categoria";

            return await db.QueryAsync<Categoria>(sql.ToString(), new { });
        }

        public Task<Categoria> GetCategory(string nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertCategory(Categoria categoria)
        {
            var db = dbConnection();
            var sql = "insert into Categoria(nombre) values(@nombre)";

            var result = await db.ExecuteAsync(sql.ToString(),
               new { categoria.nombre });
            return result > 0;
        }
    }
}
