using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaureanoNews.Interfaces
{
    interface IUserServices
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUser(string email);
    }
}
