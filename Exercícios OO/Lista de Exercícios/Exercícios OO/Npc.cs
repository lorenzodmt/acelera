using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    class Npc : Personagem2
    {
        public override void Movimentar()
        {
            Console.WriteLine("O NPC andou para frente!");
        }

        public override void Atacar()
        {
            Console.WriteLine("O NPC realizou um ataque!");
        }
    }
}
