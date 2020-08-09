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
    public class NoticeServices : INoticeServices
    {
        private readonly SqlConfiguration _configuration;
        private INoticeRepository _noticeRepository;

        public NoticeServices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _noticeRepository = new NoticeRepository(configuration.ConnectionString);
        }
        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Noticie>> GetAllNoticias()
        {
            return _noticeRepository.GetAllNotice();
        }

        public Task<Noticie> GetNotice(int id)
        {
            return _noticeRepository.GetNotice(id);
        }

        public Task<IEnumerable<Noticie>> GetNoticeByCategory(int id)
        {
            return _noticeRepository.GetNoticeByCategory(id);
        }

        public Task<IEnumerable<Noticie>> GetNoticeByCreador(string creador)
        {
            return _noticeRepository.GetNoticeByCreador(creador);
        }

        public Task<IEnumerable<Noticie>> GetNoticeByTitle(string title)
        {
            return _noticeRepository.GetNoticeByTitle(title);
        }

        public Task<IEnumerable<Noticie>> GetPublicNoticias()
        {
            return _noticeRepository.GetPublicNotice();
        }

        public Task<bool> PublicNotice(Noticie noticia)
        {
            return _noticeRepository.PublicNotice(noticia);
        }

        public Task<bool> SaveNotice(Noticie noticia)
        {
            if (noticia.Id == 0)
            {
                return _noticeRepository.InsertNotice(noticia);
            }
            else
            {
                return _noticeRepository.UpdateNotice(noticia);
            }
        }
    }
}
