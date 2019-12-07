using AmazingNews.Domain.Entities;
using AmazingNews.Domain.Services;
using AmazingNews.Infra.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private NoticiaService _noticiaService;

        public Form1()
        {
            InitializeComponent();
            _noticiaService = new NoticiaService(new NoticiaMemDbRepository());
        }

        private void btnCadastrarNoticia_Click(object sender, EventArgs e)
        {
            var noticia = new Noticia
            {
                Titulo = textBoxTitulo.Text,
                Conteudo = textBoxConteudo.Text
            };
            if (_noticiaService.AdicionarNoticia(noticia) == true)
                MessageBox.Show("Notícia Cadastrada com Sucesso!");
            else
                MessageBox.Show("Notícia Inválida!");
        }
    }
}
