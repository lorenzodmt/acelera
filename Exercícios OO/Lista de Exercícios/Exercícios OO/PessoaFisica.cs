using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    internal class PessoaFisica : Pessoa2
    {
        public override void CadastrarPessoa()
        {
            Console.WriteLine("Cadastro de pessoa física");
        }
    }
}
