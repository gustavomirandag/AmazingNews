using AmazingNews.Domain.Entities;
using AmazingNews.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingNews.Domain.Services
{
    public class NoticiaService
    {
        protected INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public bool AdicionarNoticia(Noticia noticia)
        {
            //Validação
            if (noticia.DataExpiracao < noticia.DataPublicacao)
                return false;

            //Cria o Id
            noticia.Id = Guid.NewGuid();

            return _noticiaRepository.Create(noticia);
        }

        public Noticia ObterNoticia(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Noticia> ObterNoticias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Noticia> ObterNoticiasPorTitulo(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}
