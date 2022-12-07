using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    public class Televisao
    {
        public string marca;
        public string modelo;
        public bool status;


        public void ligada()
        {
            if (status == false)
            {
                Console.WriteLine("A televisão está deslgada");
                status = true;
            }
            else
            {
                Console.WriteLine("A televisão está ligada");
                status = false;
            }
        }
    }
}
