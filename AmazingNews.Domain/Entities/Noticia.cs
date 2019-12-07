using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingNews.Domain.Entities
{
    public class Noticia
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Foto Foto { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
