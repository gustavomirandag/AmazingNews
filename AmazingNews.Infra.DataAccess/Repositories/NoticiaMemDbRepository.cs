using AmazingNews.Domain.Entities;
using AmazingNews.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingNews.Infra.DataAccess.Repositories
{
    public class NoticiaMemDbRepository : INoticiaRepository
    {
        public ICollection<Noticia> Noticias = new List<Noticia>();

        public bool Create(Noticia entity)
        {
            Noticias.Add(entity);
            return true;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Noticia Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Noticia> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Noticia entity)
        {
            throw new NotImplementedException();
        }
    }
}
