using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUserDetails(string email);
    }
}
