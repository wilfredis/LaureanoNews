using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LaureanoNews.Model;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public interface IRolRepository
    {
        Task<IEnumerable<Rol>> GetAllRols();
        Task<bool> InsertRol(Rol rol);
        Task<int> GetLastId();
    }
}
