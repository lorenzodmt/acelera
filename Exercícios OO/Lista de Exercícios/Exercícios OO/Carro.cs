using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    internal class Carro
    {
        private string modelo, cor, proprietario;
        private int anoMarca, chassi, veloMax, veloAtual, nrPortas, nrMarcha, volCombustivel;
        private bool tetoSolar, cambAuto;

        public void Acelerar()
        {
            if (veloAtual < veloMax)
            {
                veloAtual++;
            }
            else if (veloAtual > veloMax)
            {
                Console.WriteLine("Velocidade máxima atingida");
            }
        }
        public void Freiar()
        {
            if (veloAtual > 0)
            {
                veloAtual--;
            }
            else if (veloAtual==0)
            {
                Console.WriteLine("Velocidade atual = 0");
            }
        }

        //metodo elaborado
        /*        
        public void TrocarMarcha()
        {
            if (cambAuto == false)
            {
                if (nrMarcha < 5)
                {
                    atributo a ser criado para troca de marcha++;
                }
                else if (nrMarcha == 5)
                {
                    Console.WriteLine("Marcha máxima atingida");
                }
            }
            else if (cambAuto == true)
            {
                Console.WriteLine("Veículo com câmbio automático");
            }
        }
        */

        public void TrocarMarcha()
        {
            nrMarcha++;
        }
        public void ReduzirMarcha()
        {
            nrMarcha--;
        }
    }
}
