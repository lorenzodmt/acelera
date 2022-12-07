using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    internal class Aluno
    {
        public int id, dataNasc;
        public string nome, endereco, telefone;

        public Aluno(int id, int dataNasc, string nome, string endereco, string telefone)
        {
            this.id = id;
            this.dataNasc = dataNasc;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public int getId()
        { return id; }
        public int getIdade()
        { return dataNasc; }
        public string getNome()
        { return nome; }
        public string getEndereco()
        { return endereco; }
        public string getTelefone()
        { return telefone; }

    }
}
