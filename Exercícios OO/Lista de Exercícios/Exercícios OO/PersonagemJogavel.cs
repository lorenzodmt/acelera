using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    class PersonagemJogavel : Personagem2
    {
        public override void Movimentar()
        {
            Console.WriteLine($"{nome} andou para frente!");
        }

        public override void Atacar()
        {
            Console.WriteLine($"{nome} realizou um ataque!");
        }
    }
}
