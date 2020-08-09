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
    public class RolAssingServices : IRolAssingServices
    {
        private readonly SqlConfiguration _configuration;
        private IRolAssingRepository _rolassingRepository;

        public RolAssingServices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _rolassingRepository = new RolAssingRepository(configuration.ConnectionString);
        }
        public async Task<IEnumerable<RolAssing>> GetAllUserRols()
        {
            return await _rolassingRepository.GetAllUserRols();
        }

        public async  Task<RolAssing> GetUserRols(int di)
        {
            return await _rolassingRepository.GetUserRols(di);
        }

        public async Task<bool> InsertUserRols(string us, int rol)
        {
            return await _rolassingRepository.InsertUserRols(us,rol);
        }

        public async Task<bool> UpdateUserRols(string us, int rol)
        {
            return await _rolassingRepository.UpdateUserRols(us, rol);
        }
    }
}
