using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public interface INoticeRepository
    {
        Task<IEnumerable<Noticie>> GetAllNotice();
        Task<IEnumerable<Noticie>> GetPublicNotice();

        Task<Noticie> GetNotice(int id);
        Task<IEnumerable<Noticie>> GetNoticeByCreador(string category);
        Task <IEnumerable<Noticie>> GetNoticeByCategory(int id);
        Task<IEnumerable<Noticie>> GetNoticeByTitle(string title);
        Task<bool> InsertNotice(Noticie noticia);
        Task<bool> UpdateNotice(Noticie noticia);
        Task<bool> PublicNotice(Noticie noticia);

    }
}
