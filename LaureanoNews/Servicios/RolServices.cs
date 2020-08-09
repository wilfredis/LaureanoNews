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
    public class RolServices : IRolServices
    {

        private readonly SqlConfiguration _configuration;
        private IRolRepository _rolRepository;

        public RolServices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _rolRepository = new RolRepository(configuration.ConnectionString);
        }
        public async Task<IEnumerable<Rol>> GetAllRols()
        {
            return await _rolRepository.GetAllRols();
        }

       
        public async Task<int> GetLastId()
        {
            return await _rolRepository.GetLastId();
        }

        public async  Task<bool> InsertRol(Rol rol)
        {
            return await _rolRepository.InsertRol(rol);
        }


    }
}
