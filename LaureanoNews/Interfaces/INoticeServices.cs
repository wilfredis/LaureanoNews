using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaureanoNews.Model;
namespace LaureanoNews.Interfaces
{
    public interface INoticeServices
    {
        Task<IEnumerable<Noticie>> GetAllNoticias();
        Task<IEnumerable<Noticie>> GetPublicNoticias();

        Task<Noticie> GetNotice(int id);
        Task<IEnumerable<Noticie>> GetNoticeByCreador(string creador);
        Task<IEnumerable<Noticie>> GetNoticeByCategory(int id);
        Task<IEnumerable<Noticie>> GetNoticeByTitle(string title);
        Task<bool> DeleteUser(int id);
        Task<bool> PublicNotice(Noticie noticia);

        Task<bool> SaveNotice(Noticie noticia);
    }
}
