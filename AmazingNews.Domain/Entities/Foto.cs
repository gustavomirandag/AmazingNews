using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingNews.Domain.Entities
{
    public class Foto
    {
        public Guid Id { get; set; }
        public DateTime DataHora { get; set; }
        public Fotografo Fotografo { get; set; }
        public string Url { get; set; }
    }
}
