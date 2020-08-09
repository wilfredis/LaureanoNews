using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaureanoNews.Interfaces
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Categoria>> GetAllCategory();
        Task<Categoria> GetCategory(string nombre);
        Task<bool> InsertCategory(Categoria categoria);
    }
}
