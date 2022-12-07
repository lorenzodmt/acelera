using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    public class Livro
    {
        public int isbn, ano_publicacao;
        public string titulo, editora, autor, categoria;

        public Livro(int isbn, string titulo, int ano_publicacao, string editora, string autor, string categoria)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.ano_publicacao = ano_publicacao;
            this.editora = editora;
            this.autor = autor;
            this.categoria = categoria;
        }

        public int getIsbn()
        { return isbn; }

        public string getTitulo()
        { return titulo; }

        public int getAno_publicacao()
        { return ano_publicacao; }

        public string getEditora()
        { return editora; }

        public string getAutor()
        { return autor; }
        public string getCategoria()
        { return categoria; }
    }
}
