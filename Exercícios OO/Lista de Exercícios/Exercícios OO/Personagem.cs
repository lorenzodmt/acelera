using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_OO
{
    public class Personagem
    {
        public string nome;
        public int posicao;
        public int posicao_final;
        public int itens_coletados;
        public int vida = 10;
        public int opcao;


        public void andar()
        {
            if (posicao < posicao_final & vida > 0)
            {
                Console.WriteLine($"{this.nome} avançou uma casa e perdeu 2 de vida!");
                Console.WriteLine($"Vida atual: {this.vida}");
                Console.WriteLine($"Quantidade de itens: {this.itens_coletados}");
                posicao++;
                vida -= 2;
            }
            else if (vida < 0)
            {
                Console.WriteLine($"{this.nome} morreu :(");                
            }

            else if (posicao >= posicao_final)
            {
                Console.WriteLine($"{this.nome} alcançou o destino final!");
                Console.WriteLine($"Partida finalizada com {this.vida} de vida e {this.itens_coletados} itens.");
            }
        }

        public void voltar()
        {
            Console.WriteLine($"{nome} retrocedeu uma casa e ganhou 3 de vida!");
            Console.WriteLine("Um item de cura foi encontrado!");
            Console.WriteLine($"Vida atual: {vida}");
            Console.WriteLine($"Quantidade de itens: {itens_coletados}");
            posicao--;
            vida += 3;
            itens_coletados++;
        }

        public void curar()
        {
            Console.WriteLine($"Um item de cura foi usado e {nome} foi curado em 1 de vida");
            Console.WriteLine($"Vida atual: {vida}");
            Console.WriteLine($"Quantidade de itens: {itens_coletados}");
            itens_coletados--;
            vida++;
        }
    }
}
