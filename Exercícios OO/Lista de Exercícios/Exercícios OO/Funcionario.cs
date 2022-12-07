using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    internal class Funcionario
    {
        public int cpf, rg;
        public string nome, dataNasc, endereco;

        public Funcionario(int cpf, string dataNasc, int rg, string nome, string endereco)
        {
            this.cpf = cpf;
            this.dataNasc = dataNasc;
            this.rg = rg;
            this.nome = nome;
            this.endereco = endereco;
        }
        public string getNome()
        { return nome; }
        public int getCpf()
        { return cpf; }
        public string getdataNasc()
        { return dataNasc; }
        public int getRg()
        { return rg; }
        public string getEndereco()
        { return endereco; }
    }
}
