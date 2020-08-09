using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Categoria>> GetAllCategory();
        Task<Categoria> GetCategory(string nombre);
        Task<bool> InsertCategory(Categoria categoria);

    }
}
