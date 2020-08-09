using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LaureanoNews.Model;

namespace LaureanoNews.Data.Dapper.Repositorios
{
   public  interface IRolAssingRepository
    {
        Task<IEnumerable<RolAssing>> GetAllUserRols();

        Task<RolAssing> GetUserRols(int di);
        Task<bool> InsertUserRols(string us, int rol);
        Task<bool> UpdateUserRols(string us, int rol);

    }
}
