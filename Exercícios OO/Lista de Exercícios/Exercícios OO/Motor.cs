using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    internal class Motor
    {
        private string nomeFabricante, potencia, tipo;


        public void Associar()
        {
            nomeFabricante = "Chevrolet";
            potencia = "200";
            tipo = "V8";
        }

        public string RetornarNomeFabricante()
        { return nomeFabricante;}
        public string RetornarPotencia()
        { return potencia;}
        public string RetornarTipo()
        { return tipo;}
    }
}
