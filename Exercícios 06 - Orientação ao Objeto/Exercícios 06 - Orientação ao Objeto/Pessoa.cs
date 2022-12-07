using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_06___Orientação_ao_Objeto
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public string dataNasc;
        public string rg;
        public string estadoCivil;
    }

    public Pessoa(string nome, string cpf, string dataNasc, string rg, string estadoCivil)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNasc = dataNasc;
        this.rg = rg;
        this.estadoCivil = estadoCivil;
    }
}
