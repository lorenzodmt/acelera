using System.Drawing;

namespace Exercícios_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 01
            /*
            Console.WriteLine("Insira 4 valores diferentes para calcular a média entre eles");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float media = (a + b + c + d) / 4;

            Console.WriteLine("A média entre os valores "+a+" + "+b+" + "+c+" + "+d+" é de "+media);
            */






            //EXERCÍCIO 02
            /*
            Console.WriteLine("Quantidade de horas de aula dadas por dois professores");
            float horas_prof_a = float.Parse(Console.ReadLine());
            float horas_prof_b = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora recebido por cada um dos professores");
            float valor_prof_a = float.Parse(Console.ReadLine());
            float valor_prof_b = float.Parse(Console.ReadLine());
            float salario_a = horas_prof_a * valor_prof_a;
            float salario_b = horas_prof_b * valor_prof_b;

            if (salario_a > salario_b)
            {
                Console.WriteLine("O professor A tem o maior salário total.");
            }
            else
            {
                Console.WriteLine("O professor B tem o maior salário total.");
            }
            */







            //EXERCÍCIO 03
            /*
            int i, op;
            for (i = 0; true; i++)
            {
                Console.WriteLine("Insira um valor entre 1 e 12");
                op = int.Parse(Console.ReadLine());
                if (op > 12 || op < 1)
                {
                    Console.WriteLine("Serão aceitos somente valores entre 1 e 12");
                    continue;
                }
                else
                {
                    Console.WriteLine("Opção "+op+" escolhida!");
                    break;
                }                
            }
            switch (op)
            {
                case 1:
                    Console.WriteLine("O mês escolhido é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês escolhido é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês escolhido é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês escolhido é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês escolhido é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês escolhido é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês escolhido é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês escolhido é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês escolhido é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês escolhido é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês escolhido é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês escolhido é Dezembro");
                    break;
            }
            */







            //EXERCÍCIO 04 DUVIDAS!!!!!!!
            /*
            int i, op, idioma=0;
            for (i = 0; true; i++)
            {
                Console.WriteLine("Insira um valor entre 0 e 9");
                op = int.Parse(Console.ReadLine());
                if (op > 9 || op < 1)
                {
                    Console.WriteLine("Apenas valores entre 0 e 9");
                    continue;
                }
                else
                {
                    Console.WriteLine("Valor " + op + " escolhido!");
                    break;
                }
            }
            for (i = 0; true; i++)
            {
                Console.WriteLine("Qual idioma deseja: português [1], inglês [2] ou espanhol [3]");
                idioma = int.Parse(Console.ReadLine());
                if (idioma > 3 || idioma < 0)
                {
                    Console.WriteLine("Apenas valores entre 1 e 3");
                    continue;
                }
                else
                {
                    Console.WriteLine("Idioma " + idioma + " escolhido!");
                    break;
                }
            }
            switch(op)
            {
                case 0:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Zero");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Zero");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Cero");
                    }
                    break;

                case 1:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Um");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("One");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Uno");
                    }
                    break;

                case 2:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Dois");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Two");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Dos");
                    }
                    break;

                case 3:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Três");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Tree");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Tres");
                    }
                    break;
                case 4:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Quatro");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Four");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Cuatro");
                    }
                    break;
                case 5:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Cinco");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Five");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Cinco");
                    }
                    break;
                case 6:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Seis");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Six");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Seis");
                    }
                    break;
                case 7:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Sete");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Seven");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Siete");
                    }
                    break;
                case 8:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Oito");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Eight");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Ocho");
                    }
                    break;
                case 9:
                    if (idioma == 1)
                    {
                        Console.WriteLine("Nove");
                    }
                    else if (idioma == 2)
                    {
                        Console.WriteLine("Nine");
                    }
                    else if (idioma == 3)
                    {
                        Console.WriteLine("Nueve");
                    }
                    break;
            }*/







            //EXERCÍCIO 05
            /*
            Console.WriteLine("Digite uma letra");
            char letra = char.Parse(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                    {
                        Console.WriteLine("A letra é vogal");
                        break;
                    }
                case 'e':
                    {
                        Console.WriteLine("A letra é vogal");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("A letra é vogal");
                        break;
                    }
                case 'o':
                    {
                        Console.WriteLine("A letra é vogal");
                        break;
                    }
                case 'u':
                    {
                        Console.WriteLine("A letra é vogal");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("A letra é consoante");
                        break;
                    }
            }*/







            //EXERCÍCIO 06
            /*
            Console.WriteLine("Insira um valor para hora, minuto e segundo");
            int hora = int.Parse(Console.ReadLine());
            int minuto = int.Parse(Console.ReadLine());
            int segundo = int.Parse(Console.ReadLine());

            for (int i = 0; true; i++)
            {
                if (hora > 23 || hora < 0 || minuto > 59 || minuto < 0 || segundo > 59 || segundo < 0)
                {
                    Console.WriteLine("Para um horário ser válido, a hora deve estar no intervalo de 0 a 23, o minuto e o segundo no intervalo de 0 a 59.");
                    continue;
                }
                else
                {
                    Console.WriteLine("O horário "+hora+"h:"+minuto+"m:"+segundo+"s é válido");
                    break;
                }
            }
            */





            //EXERCÍCIO 07
            /*
            Console.WriteLine("Insira o valor da renda familiar e o número de integrantes da família");
            float renda = float.Parse(Console.ReadLine());
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor da renda per capita dessa família é de "+(renda/numero));
            */





            //EXERCÍCIO 08
            /*
            Console.WriteLine("Insira o valor da compra: ");
            float valor_compra = float.Parse(Console.ReadLine());

            if (valor_compra < 10)
            {
                Console.WriteLine("Lucro de 70% em cima do valor de compra R$ "+valor_compra);
            }
            else if (10 <= valor_compra || valor_compra < 30)
            {
                Console.WriteLine("Lucro de 50% em cima do valor de compra R$ " + valor_compra);
            }
            else if (30 <= valor_compra || valor_compra < 50)
            {
                Console.WriteLine("Lucro de 40% em cima do valor de compra R$ " + valor_compra);
            }
            else if (valor_compra >= 50)
            {
                Console.WriteLine("Lucro de 30% em cima do valor de compra R$ " + valor_compra);
            }
            */




            //EXERCÍCIO 09
            /*
            Console.WriteLine("Insira os 3 lados do Triângulo");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < (b + c) || b < (c + a) || c < (a + b))
            {
                Console.WriteLine("Os lados podem formar um triângulo");
            }
            else
            {
                Console.WriteLine("Os lados não podem formar um triângulo");
            }
            */







            //EXERCÍCIO 10
            /*
            Console.WriteLine("Digite um número para tabular");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 15; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\nTABUADA DO " + num);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }

            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            */






            //EXERCÍCIO 11
            /*
            for (int i = 1000; i < 2000; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i);
                }
            }
            */





            //EXERCÍCIO 12
            /*
            Console.WriteLine("Insira um valor mínimo e máximo");
            int numero_min = int.Parse(Console.ReadLine());
            int numero_max = int.Parse(Console.ReadLine());

            int i, soma_total = 0;
            for (i = numero_min; i <= numero_max; i++)
            {
                if (i % 2 == 0)
                {
                    soma_total += i;
                }
            }
            Console.WriteLine(soma_total);
            */





            //EXERCÍCIO 13
            /*
            Console.WriteLine("Digite qual o valor inicial da contagem, qual o valor final");
            int valor_inicial = int.Parse(Console.ReadLine());
            int valor_final = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja pular os números pares [1] ou ímpares [2]?");
            int op = int.Parse(Console.ReadLine());


            for (int i = valor_inicial; i <= valor_final; i++)
            {
                if (op == 1)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            */






            //EXERCÍCIO 14
            /*
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i+" polegada(s) = "+(i*2.54)+" centímetro(s)");
            }
            */





            //EXERCÍCIO 15
            /*                        
            Console.WriteLine("Insira os valores iniciais e finais da contagem");
            int inicial = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());

            for (int i = inicial; i <= final; i++)
            {
                Console.WriteLine(i);
            }
            */





            //EXERCÍCIO 16
            /*
            Console.WriteLine("Insira os valores iniciais e finais da contagem");
            int inicial = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja que os números apareçam em ordem crescente [1] ou decrescente [2]");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                for (int i = inicial; i <= final; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = final; i >= inicial; i--)
                {
                    Console.WriteLine(i);
                }
            }
            */





            //EXERCÍCIO 17
            /*
            int i;

            for (i = 0; i < 10; i++)
            {                    
                Console.WriteLine("Volta numero :" + i);
                if (i == 5)
                {
                    break;
                }
            }
            */




            //EXERCÍCIO 18
            /*
            int i;

            for (i = 0; i < 10; i++)
            {                
                if (i == 5 || i == 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Volta numero :" + i);
                }
            }
            */



            //EXERCÍCIO 19
            /*
            float dividendo = 1000, resultado = 0;
            for (int divisor = 1; divisor <= 50; divisor++)
            {
                if (divisor % 2 == 1)
                {
                    resultado += dividendo / divisor;
                }
                else
                {
                    resultado -= dividendo / divisor;
                }
                dividendo -= 3;
            }
            Console.WriteLine("O resultado da expressão é "+resultado);
            */




            //EXERCÍCIO 20
            
            Console.WriteLine("Digite um número para saber se ele é primo ou não:");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 2; i <= 10; i++)
            {
                if (numero % i == 0)
                {
                    resultado++;
                    break;
                }
            }
            if (resultado == 0)
            {
                Console.WriteLine("O número "+numero+" é primo!");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não é primo!");
            }
            


            //OUTRO MÉTODO -> PREGUIÇOSO
            /*
            Console.WriteLine("Digite um número para saber se ele é primo ou não:");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1) 
            {
                Console.WriteLine("O número "+numero+" não é primo!");
            }
            else if (numero % 1 == 0 && numero % numero == 0 && numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " não é primo!");
            }
            else if (numero % 1 == 0 && numero % numero == 0 && numero % 3 == 0)
            {
                Console.WriteLine("O número " + numero + " não é primo!");
            }
            else if (numero % 1 == 0 && numero % numero == 0 && numero % (numero/2) == 0)
            {
                Console.WriteLine("O número " + numero + " não é primo!");
            }
            else if (numero % 1 == 0 && numero % numero == 0)
            {
                Console.WriteLine("O número "+numero+" é primo!");
            }
            else
            {
                Console.WriteLine("O número "+numero+" não é primo!");
            }
            */
        }
    }
}