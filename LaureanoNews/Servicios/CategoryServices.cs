using LaureanoNews.Data;
using LaureanoNews.Data.Dapper.Repositorios;
using LaureanoNews.Interfaces;
using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaureanoNews.Servicios
{
    public class CategoryServices : ICategoryServices
    {
        private readonly SqlConfiguration _configuration;
        private ICategoryRepository _categoryRepository;

        public CategoryServices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _categoryRepository = new CategoryRepository(configuration.ConnectionString);
        }
        public async Task<IEnumerable<Categoria>> GetAllCategory()
        {
            return await _categoryRepository.GetAllCategory();
        }

        public Task<Categoria> GetCategory(string nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertCategory(Categoria categoria)
        {
            return await _categoryRepository.InsertCategory(categoria);
        }
    }
}
