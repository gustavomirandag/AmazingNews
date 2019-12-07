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
            //Prepara��o
            INoticiaRepository noticiaRepository = new NoticiaMemDbRepository();
            var noticiaService = new NoticiaService(noticiaRepository);
            var noticia = new Noticia
            {
                Id = Guid.NewGuid(),
                Titulo = "D�lar cai a R$3",
                DataPublicacao = DateTime.Now,
                DataExpiracao = DateTime.Now.AddDays(1)
            };

            //Execu��o
            var result = noticiaService.AdicionarNoticia(noticia);

            //Valida��o
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdicionarNoticiaSemSucesso()
        {
            //Adicionar not�cia com data de publica��o maior
            //que a data de expira��o.
            //Prepara��o
            INoticiaRepository noticiaRepository = new NoticiaMemDbRepository();
            var noticiaService = new NoticiaService(noticiaRepository);
            var noticia = new Noticia
            {
                Id = Guid.NewGuid(),
                Titulo = "D�lar cai a R$3",
                DataPublicacao = DateTime.Now.AddDays(1),
                DataExpiracao = DateTime.Now
            };

            //Execu��o
            var result = noticiaService.AdicionarNoticia(noticia);

            //Valida��o
            Assert.IsFalse(result);
        }
    }
}
