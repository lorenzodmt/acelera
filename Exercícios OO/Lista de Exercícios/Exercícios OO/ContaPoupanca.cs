using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    class ContaPoupanca : ContaBancaria
    {
        private int limite = 1000;
        
        public override double Depositar() => saldo += 50;
        public override double Sacar() => saldo += limite - 500;
        
    }
}
