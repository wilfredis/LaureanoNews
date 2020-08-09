using LaureanoNews.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace LaureanoNews.Data.Dapper.Repositorios
{
    public class NoticeRepository : INoticeRepository
    {
        private string ConnectionString;

        public NoticeRepository(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<IEnumerable<Noticie>> GetAllNotice()
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia ";

            return await db.QueryAsync<Noticie>(sql.ToString(), new { });
        }

        public async Task<Noticie> GetNotice(int id)
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia where id = @id ";

            return await db.QueryFirstOrDefaultAsync<Noticie>(sql.ToString(), new { id = id });
        }

        public async Task<IEnumerable<Noticie>> GetNoticeByCategory(int id)
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia where Categoria =@Categoria and Publicado = 1";

            return await db.QueryAsync<Noticie>(sql.ToString(), new { Categoria = id });
        }

        public async Task<IEnumerable<Noticie>> GetNoticeByTitle(string title)
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia  where Titular like @Titular and Publicado = 1";

            return await db.QueryAsync<Noticie>(sql.ToString(), new { Titular = title+"%" });
        }

        public async Task<bool> InsertNotice(Noticie noticia)
        {
            var db = dbConnection();

            var sql = "insert into Noticia(Titular,Portada,Contenido,FechaCreacion,Publicado,Creador,Resumen,Categoria)" +
                      " values(@Titular,@Portada,@Contenido,@FechaCreacion,@Publicado,@Creador,@Resumen,@Categoria)";
      
            noticia.Publicado = false;
            noticia.FechaCreacion = DateTime.Now.Date;

            var result = await db.ExecuteAsync(sql.ToString(),
                new { noticia.Titular, noticia.Portada, noticia.Contenido, noticia.FechaCreacion, noticia.Publicado, noticia.Creador, noticia.Resumen, noticia.Categoria });
            return result > 0;
        }

        public async Task<bool> UpdateNotice(Noticie noticia)
        {
            var db = dbConnection();

            var sql = "update Noticia set Titular = @Titular,Portada =@Portada,Contenido =@Contenido,Categoria = @Categoria," +
                      "Resumen = @Resumen where id = @id";

            noticia.Publicado = false;
            noticia.FechaCreacion = DateTime.Now.Date;

            var result = await db.ExecuteAsync(sql.ToString(),
                new { noticia.Titular, noticia.Portada, noticia.Contenido, noticia.Resumen,noticia.Id,noticia.Categoria });
            return result > 0;
        }

        public async Task<IEnumerable<Noticie>> GetNoticeByCreador(string creador)
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia where Creador = @Creador ";

            return await db.QueryAsync<Noticie>(sql.ToString(), new { Creador = creador });
        }

        public async Task<bool> PublicNotice(Noticie noticia)
        {
            var db = dbConnection();

            var sql = "update Noticia set FechaPublicacion = @FechaPublicacion,Publicado = @Publicado where id = @id";
                      
            var result = await db.ExecuteAsync(sql.ToString(),
                new { noticia.FechaPublicacion, noticia.Publicado, noticia.Id });
            return result > 0;
        }

        public async Task<IEnumerable<Noticie>> GetPublicNotice()
        {
            var db = dbConnection();

            var sql = "select id,Titular,Portada,Contenido,FechaCreacion,FechaPublicacion" +
                ",Publicado,Resumen,Creador,Categoria from Noticia where Publicado = 1 ";

            return await db.QueryAsync<Noticie>(sql.ToString(), new { });
        }
    }
}
