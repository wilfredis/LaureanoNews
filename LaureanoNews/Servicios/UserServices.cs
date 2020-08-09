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
    public class UserServices : IUserServices
    {
        private readonly SqlConfiguration _configuration;
        private IUserRepository _userRepository;

        public UserServices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _userRepository = new UserRepository(configuration.ConnectionString);
        }
        public Task<IEnumerable<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string email)
        {
            return _userRepository.GetUserDetails(email);
        }
    }
}
