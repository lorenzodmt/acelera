using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    abstract class Personagem2
    {
        public string nome;
        public int x, y, hp;

        public int RetornaPosicaoX()
        {
            return x;
        }
        public int RetornaPosicaoY()
        {
            return y;
        }

        abstract public void Movimentar();

        abstract public void Atacar();
    }
}
