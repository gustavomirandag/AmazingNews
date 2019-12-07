using AmazingNews.Domain.Entities;
using AmazingNews.Domain.Interfaces.Repositories;
using AmazingNews.Domain.Services;
using AmazingNews.Infra.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmazingNews.Test.DomainServiceUnitTest
{
    [TestClass]
    public class NoticiaServiceUnitTest
    {
        [TestMethod]
        public void AdicionarNoticiaComSucesso()
        {
            //Preparação
            INoticiaRepository noticiaRepository = new NoticiaMemDbRepository();
            var noticiaService = new NoticiaService(noticiaRepository);
            var noticia = new Noticia
            {
                Id = Guid.NewGuid(),
                Titulo = "Dólar cai a R$3",
                DataPublicacao = DateTime.Now,
                DataExpiracao = DateTime.Now.AddDays(1)
            };

            //Execução
            var result = noticiaService.AdicionarNoticia(noticia);

            //Validação
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdicionarNoticiaSemSucesso()
        {
            //Adicionar notícia com data de publicação maior
            //que a data de expiração.
            //Preparação
            INoticiaRepository noticiaRepository = new NoticiaMemDbRepository();
            var noticiaService = new NoticiaService(noticiaRepository);
            var noticia = new Noticia
            {
                Id = Guid.NewGuid(),
                Titulo = "Dólar cai a R$3",
                DataPublicacao = DateTime.Now.AddDays(1),
                DataExpiracao = DateTime.Now
            };

            //Execução
            var result = noticiaService.AdicionarNoticia(noticia);

            //Validação
            Assert.IsFalse(result);
        }
    }
}
