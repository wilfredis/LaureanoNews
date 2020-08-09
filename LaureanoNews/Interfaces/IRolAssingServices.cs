using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaureanoNews.Interfaces
{
    public interface IRolAssingServices
    {
        Task<IEnumerable<RolAssing>> GetAllUserRols();

        Task<RolAssing> GetUserRols(int di);

        Task<bool> InsertUserRols(string us, int rol);
        Task<bool> UpdateUserRols(string us, int rol);

    }
}
