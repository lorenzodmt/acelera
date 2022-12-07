using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    class ContaCorrente : ContaBancaria
    {
        private int taxaDeOperacao = 3;
        public override double Depositar() => saldo += 300 - taxaDeOperacao;
        public override double Sacar() => saldo -= 50 - taxaDeOperacao;
    }
}
