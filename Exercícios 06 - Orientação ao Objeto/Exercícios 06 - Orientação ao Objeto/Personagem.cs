using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_06___Orientação_ao_Objeto
{
    internal class Personagem
    {
        public string nome;
        public int posicao;
        public int posicao_final;
        public int itens_coletados;
        public int vida = 10;
        public int opcao;

        public void opcoes()
        {
            Console.WriteLine("SELECIONE UMA OPÇÃO:");
            Console.WriteLine("1 - Andar (avança 1 casa e perde 2 de vida)");
            Console.WriteLine("2 - Voltar (retrocede 1 casa, ganha 3 de vida e recebe 1 item de cura)");
            Console.WriteLine("3 - Curar (consome 1 item de cura e recebe 1 de vida)");
        }

        public void andar()
        {
            if (posicao < posicao_final)
            {
                Console.WriteLine($"{nome} avançou uma casa e perdeu 2 de vida!");
                Console.WriteLine($"Vida atual: {vida}");
                Console.WriteLine($"Quantidade de itens: {itens_coletados}");
                posicao++;
                vida -= 2;
            }

            if (posicao >= posicao_final)
            {
                Console.WriteLine($"{nome} alcançou o destino final!");
                Console.WriteLine($"Partida finalizada com {vida} de vida e {itens_coletados} itens.");
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
