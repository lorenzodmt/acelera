using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    abstract class ContaBancaria
    {
        public int numConta, saldo;

        abstract public double Sacar();

        abstract public double Depositar();
    }
}
