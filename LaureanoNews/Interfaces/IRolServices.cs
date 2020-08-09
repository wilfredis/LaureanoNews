using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaureanoNews.Interfaces
{
    public interface IRolServices
    {
        Task<IEnumerable<Rol>> GetAllRols();
        Task<bool> InsertRol(Rol rol);
        Task<int> GetLastId();

       
    }
}
