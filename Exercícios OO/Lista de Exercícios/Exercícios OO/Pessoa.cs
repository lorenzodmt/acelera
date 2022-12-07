using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public string dataNasc;
        public string rg;
        public string estadoCivil;
        
        public string cadastroNome()
        { return nome; }
        public string cadastroCpf()
        { return cpf; }
        public string cadastroDataNasc()
        { return dataNasc; }
        public string cadastroRg()
        { return rg; }
        public string cadastroEstadoCivil()
        { return estadoCivil; }

    }
}
