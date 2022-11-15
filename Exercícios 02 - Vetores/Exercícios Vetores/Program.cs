using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace Exercícios_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            /*
            int i;
            int par = 0, impar = 0;
            for  (i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " ");
                if (i % 2 == 0)
                {
                    par++;
                }
                else if (i % 2 == 1)
                {
                    impar++;
                }
            }
            Console.WriteLine("Há " + par + " números pares e " + impar + " números ímpares");
            */



            //Exercício 02
            /*
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("a soma de " + i + " + " + j + " = " + (i + j));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            */

            //Exercício 03
            /*
            int indice;
            int[] vetor = new int[10];
            int contador = 0;

            for (indice = 0; indice < 10; indice++)
            {
                Console.Write($"Digite o [{indice}] número: ");
                vetor[indice] = int.Parse(Console.ReadLine());
            }

            for (indice = 0; indice < 10; indice++)
            {
                for (int divisao = 0; divisao < 10; divisao++)
                {
                    if (divisao != 0)//para nao dividir por 0
                    {
                        if (vetor[indice] % divisao == 0)
                        {
                            contador++;
                        }
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine($"Número {vetor[indice]} é primo e está na posição {indice}");
                }
                contador = 0;
            }
            */


            //Exercício 04
            /*
            int i;
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os numeros");
                A[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os numeros");
                B[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                C[i] = A[i] * B[i];
                Console.WriteLine("A multiplicação dos vetores é: " + C[i]);
            }
            */



            //Exercício 05
            /*
            int i, menor;
            int[] vetor = new int[10];
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os numeros");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            menor = vetor[0];

            for (i = 0; i < 10; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine("O menor numero é :" + menor);
            */



            //Exercício 06
            /*
            int i;
            int[] vetor = new int[10];
            int[] vetor_B = new int[10];

            for (i = 0; i < 10; i++)
            {
                vetor[i] = i;
                Console.Write("|" + vetor[i]);
            }
            Console.WriteLine();
            Console.WriteLine("A ordem inversa é: ");
            for (i = 0; i < 10; i++)
            {
                vetor_B[i] = vetor[9-i];
                Console.Write("|" + vetor_B[i]);
            }
            */



            //Exercício 07
            /*
            int i;
            int[] vetor = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            for (i = 0; i < 10; i++)
            {
                vetor[i] = i;
                Console.Write("|" + vetor[i]);
            }
            Console.WriteLine();
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares[i] = i;
                    Console.Write("|" + pares[i]);
                }                
            }
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    impares[i] = i;
                    Console.Write("|" + impares[i]);
                }
            }
            */





            //Exercício 08
            /*
            int i;
            int[] a = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os numeros desejados");

                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Pares: ");
            for (i = 0; i < 10; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.Write(" Ímpares: ");
            for (i = 0; i < 10; i++)
            {
                if (a[i] % 2 == 1)
                {
                    Console.Write(a[i] + " ");
                }
            }
            */





            //Exercício 09
            /*
            
            int i, j, aux = 0;
            int[] vetor = new int[10];


            //Preencher
            Console.WriteLine("Preencha o Vetor com valores aleatórios");
            for (i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            //Ordenar
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }                    
                }
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("[" + vetor[i] + "]");
            }
            */





            //Exercício 10
            /*
            int i;
            int[] a = new int[10];
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os numeros");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os numeros do segundo vetor (if valor null = 2) são: ");

            for (i = 0; i < 10; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 2;
                }
                Console.WriteLine(a[i]);
            }*/


            //Exercício 11
            /*
            int i;
            int[] vetor = new int[5];
            int[] vetor_B = new int[5];

            for (i = 0; i < 5; i++)
            {
                vetor[i] = i;
                Console.Write("|" + vetor[i]);
            }
            Console.WriteLine();
            Console.WriteLine("A ordem inversa é: ");
            for (i = 0; i < 5; i++)
            {
                vetor_B[i] = vetor[4 - i];
                Console.Write("|" + vetor_B[i]);
            }
            */


            //Exercício 12
            /*
            int i, N;
            bool achou = false;
            int[] vetor = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Insira um número para saber se ele existe no vetor");
            N = int.Parse(Console.ReadLine());
            for (i = 0; i < 10; i++)
            {
                if (N == vetor[i])
                {
                    achou = true;
                    Console.WriteLine($"[{N}] na {i + 1}ª posição");
                }
            }
            if (achou == false)
            {
                Console.Write("O número fornecido não existe no vetor ");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("[" + vetor[i] + "]");
                }
            }
            */




            //Exercício 13
            /*
            int i, num_2 = 0, num_4 = 0, num_8 = 0;
            int[] vetor = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < 0 || vetor[i] == 10)
                {
                    break;
                }
                else if (vetor[i] == 2)
                {
                    num_2++;
                }
                else if (vetor[i] == 4)
                {
                    num_4++;
                }
                else if (vetor[i] == 8)
                {
                    num_8++;
                }
            }
            Console.WriteLine($"Os números 2, 4 e 8 aparecem [{num_2}], [{num_4}] e [{num_8}] vezes.");
            */



            //Exercício 14 NAO CONSEGUI A PARTE DA ORDEM INVERSA, tentei de modos diferentes e n deu
            /*
            int cod, i, j, parada = 0;
            int[] vetor = new int[20];                                    
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o valor da {i}ª posição, [0] para parar");
                vetor[i] = int.Parse(Console.ReadLine());
                parada = i;

                if (vetor[i] == 0)
                {
                    parada = i;
                    break;
                }
            }

            Console.WriteLine("Digite [1] para vetor de ordem direta e [2] para ordem inversa");
            cod = int.Parse(Console.ReadLine());
            if (cod == 1)
            {
                for (i = 0; i < parada; i++)
                {
                    Console.Write($"[{vetor[i]}]");
                }
            }

            else if (cod == 2)
            {                  
                for (i = parada; i >= 0; i--)
                {
                    Console.Write($"[{vetor[i]}]");
                }                    
            }

            if (cod > 2 || cod < 1)
            {
                Console.WriteLine("Valor inválido!");
            }
            */




            //Exercício 15 dificuldade na parte de inverter com bubble sort 
            /*
            int i, j;
            int[] vetor = new int[20];
            int[] vetor2 = new int[20];
            for (i = 0; i < 20; i++)
            {
                vetor[i] = i;
            }
            for (i = 19; i > 0; i--)
            {
                Console.Write($"[{vetor[i]}]");
            }
            */



            //Exercícios 16
            //uniao e diferença nao consegui        
            /*
            int[] A = new int[10];
            int[] B = new int[10];
            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] intersecao = new int[10];
            int i, cont = 0, numIntersecoes = 0;
            Random random = new Random();



            Console.WriteLine("Vetor A");
            for (i = 0; i < 10; i++)
            {
                A[i] = i;
                Console.Write($"[{A[i]}]");
            }

            Console.WriteLine();

            Console.WriteLine("Vetor B");
            for (i = 0; i < 10; i++)
            {
                B[i] = i + 5;
                Console.Write($"[{B[i]}]");
            }

            Console.WriteLine();

            Console.WriteLine("União");
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (A[i] != B[j])
                    {
                        uniao[i] = A[i] + B[j];
                    }
                }
                Console.Write($"[{uniao[i]}]");
            }

            Console.WriteLine("\n\nDiferença");
            for (i = 0; i < 10; i++)
            {
                diferenca[i] = A[i] - B[i];
                Console.Write($"[{diferenca[i]}]");
            }


            Console.WriteLine("\n\nInterseção");
            for (i = 0; i < 10; i++)
            {
                if (A[i] == B[i])
                {
                    intersecao[i] = A[i];
                    numIntersecoes++;
                    Console.Write($"[{intersecao[i]}]");
                }

                else
                {
                    cont++;
                }
            }

            if (cont != 0 && numIntersecoes == 0)
            {
                Console.WriteLine("Não existe interseção!");
            }
            */
        }
    }
}