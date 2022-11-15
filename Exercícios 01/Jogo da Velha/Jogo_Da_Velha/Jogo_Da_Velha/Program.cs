using System.Linq.Expressions;

namespace Jogo_Da_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variaveis 

           
            int op = -1, cont = 0, j = 0, jogar = -1;

            // Cabeçalho 

            Console.Write("-------------- JOGO DA VELHA EM C# -------------");
            Console.Write("\n\n");

            


            while(jogar != 2)
            {
                op = -1;
                Console.Write("\n");
                Console.Write("                    JOGAR ?\n\n");
                Console.Write("      Escolha 1 para SIM ou 2 para NAO/: ");
                jogar = int.Parse(Console.ReadLine());
                Console.Write("\n");

                while (jogar < 1 || jogar > 2)
                {
                    Console.Write("\n");
                    Console.Write("                    JOGAR ?\n\n");
                    Console.Write("      Escolha 1 para SIM ou 2 para NAO/: ");
                    jogar = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                }
                if (jogar == 2)
                {
                    Environment.Exit(0);
                }
                // CRIA MATRIZ

                string[,] tabela = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

                while (op != 0)
                {
                    

                    //--------------------------------------------------------JOGADOR 1--------------------------------------------------------//

                    // IMPRIME

                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (j == 0)
                            {
                                Console.Write("                     ");
                            }

                            Console.Write(tabela[i, j] + " ");

                        }
                        Console.Write("\n");
                    }

                    bool f = true;
                    while (f == true)
                    {
                        // ENTRADA DO USUARIO

                        Console.Write("\n");
                        Console.Write("                   JOGADOR 1\n\n");
                        Console.Write("Escolha uma posição no tabuleiro ou 0 para sair/: ");
                        op = int.Parse(Console.ReadLine());
                        Console.Write("\n");

                        while (op < 0 || op > 9)
                        {
                            Console.Write("Você Digitou uma posição invalida ! \n\n");
                            Console.Write("Escolha uma posição no tabuleiro /: ");
                            op = int.Parse(Console.ReadLine());
                            Console.Write("\n");
                        }

                        // ADICIONA X JOGADOR 1

                        if (op == 0)
                        {
                            break;
                        }

                        switch (op)
                        {

                            case 1:
                                if (tabela[0,0] == "O" || tabela[0, 0] == "X")
                                {
                                    f = true;
                                }else
                                if (tabela[0, 0] != "O" || tabela[0, 0] != "X")
                                {
                                    tabela[0, 0] = "X";
                                    f = false;
                                }
                                break;
                            case 2:
                                if (tabela[0, 1] == "O" || tabela[0, 1] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[0, 1] != "O")
                                {
                                    tabela[0, 1] = "X";
                                    f = false;
                                }
                                
                                break;
                            case 3:
                                if (tabela[0, 2] == "O" || tabela[0, 2] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[0, 2] != "O")
                                {
                                    tabela[0, 2] = "X";
                                    f = false;
                                }
                               
                                break;
                            case 4:
                                if (tabela[1, 0] == "O" || tabela[1, 0] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[1, 0] != "O")
                                {
                                    tabela[1, 0] = "X";
                                    f = false;
                                }
                                
                                break;
                            case 5:
                                if (tabela[1, 1] == "O" || tabela[1, 1] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[1, 1] != "O")
                                {
                                    tabela[1, 1] = "X";
                                    f = false;
                                }
                                
                                break;
                            case 6:
                                if (tabela[1, 2] == "O" || tabela[1, 2] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[1, 2] != "O")
                                {
                                    tabela[1, 2] = "X";
                                    f = false;
                                }
                               
                                break;
                            case 7:
                                if (tabela[2, 0] == "O" || tabela[2, 0] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[2, 0] != "O")
                                {
                                    tabela[2, 0] = "X";
                                    f = false;
                                }
                               
                                break;
                            case 8:
                                if (tabela[2, 1] == "O" || tabela[2, 1] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[2, 1] != "O")
                                {
                                    tabela[2, 1] = "X";
                                    f = false;
                                }
                               
                                break;
                            case 9:
                                if (tabela[2, 2] == "O" || tabela[2, 2] == "X")
                                {
                                    f = true;
                                }
                                else
                                if (tabela[2, 2] != "O")
                                {
                                    tabela[2, 2] = "X";
                                    f = false;
                                }
                                
                                break;
                        }

                    }
                    //IMPRIME

                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (j == 0)
                            {
                                Console.Write("                     ");
                            }

                            Console.Write(tabela[i, j] + " ");

                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");

                    cont = 0;
                    // VERIFICA EMPATE
                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[i, j] == "X" || tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                    }
                    if(cont == 9)
                    {
                        Console.Write("\n\n                O JOGO EMPATOU !!!\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }
                    // VARIFICA JOGO HORIZONTAL

                    cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                           if(tabela[i, j] == "X")
                           {
                                cont ++;
                           }
                        }
                        if (cont == 3)
                        {
                            Console.Write("\n\n           JOGADOR 1 GANHOU HORIZONTAL\n\n");
                            op = 0;
                            break;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                
                    // VARIFICA JOGO VERTICAL
                    cont = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[j, i] == "X")
                            {
                                cont++;
                            }
                        }
                        if (cont == 3)
                        {
                            Console.Write("\n\n           JOGADOR 1 GANHOU VERTICAL\n\n");
                            op = 0;
                            break;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
               
                    // VARIFICA JOGO DIAGONAL DIREITA
                    cont = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (i == j)
                            {
                                if (tabela[i, j] == "X")
                                {
                                    cont++;
                                }
                            }
                        }
                    }
                    if (cont == 3)
                    {
                        Console.Write("\n\n           JOGADOR 1 GANHOU DIREITA\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }

                    // VARIFICA JOGO DIAGONAL ESQUERDA

                    cont = 0;
                    j = 2;

                    for (int i = 0; i < 3; i++)
                    {

                        if (tabela[i, j] == "X")
                        {
                            cont++;
                            j--;
                        }
                    }
                    if (cont == 3)
                    {
                        Console.Write("\n\n           JOGADOR 1 GANHOU ESQUERDA\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }
                    cont = 0;

                    //--------------------------------------------------------JOGADOR 2--------------------------------------------------------//

                    if (op == 0)
                    {
                        break;
                    }

                    bool z = true;
                    while (z == true)
                    {
                        // ENTRADA DO USUARIO 2

                        Console.Write("\n");
                        Console.Write("                   JOGADOR 2\n\n");
                        Console.Write("Escolha uma posição no tabuleiro ou 0 para sair/: ");
                        op = int.Parse(Console.ReadLine());
                        Console.Write("\n");

                        while (op < 0 || op > 9)
                        {
                            Console.Write("Você Digitou uma posição invalida ! \n\n");
                            Console.Write("Escolha uma posição no tabuleiro /: ");
                            op = int.Parse(Console.ReadLine());
                            Console.Write("\n");
                        }

                        // ADICIONA O JOGADOR 2

                        if (op == 0)
                        {
                            break;
                        }

                        switch (op)
                        {

                            case 1:
                                if (tabela[0, 0] == "O" || tabela[0, 0] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[0, 0] != "X")
                                {
                                    tabela[0, 0] = "O";
                                    z = false;
                                }
                                break;
                            case 2:
                                if (tabela[0, 1] == "O" || tabela[0, 1] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[0, 1] != "X" || tabela[0, 1] != "O")
                                {
                                    tabela[0, 1] = "O";
                                    z = false;
                                }
                                break;
                            case 3:

                                if (tabela[0, 2] == "O" || tabela[0, 2] == "X")
                                {
                                    z = true;
                                }
                                else
                               if (tabela[0, 2] != "X")
                                {
                                    tabela[0, 2] = "O";
                                    z = false;
                                }
                                break;
                            case 4:
                                if (tabela[1, 0] == "O" || tabela[1, 0] == "X")
                                {
                                    z = true;
                                }
                                else
                               if (tabela[1, 0] != "X")
                                {
                                    tabela[1, 0] = "O";
                                    z = false;
                                }
                                break;
                            case 5:
                                if (tabela[1, 1] == "O" || tabela[1, 1] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[1, 1] != "X")
                                {
                                    tabela[1, 1] = "O";
                                    z = false;
                                }
                                break;
                            case 6:
                                if (tabela[1, 2] == "O" || tabela[1, 2] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[1, 2] != "X")
                                {
                                    tabela[1, 2] = "O";
                                    z = false;
                                }
                                break;
                            case 7:
                                if (tabela[2, 0] == "O" || tabela[2, 0] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[2, 0] != "X")
                                {
                                    tabela[2, 0] = "O";
                                    z = false;
                                }
                                break;
                            case 8:
                                if (tabela[2, 1] == "O" || tabela[2, 1] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[2, 1] != "X")
                                {
                                    tabela[2, 1] = "O";
                                    z = false;
                                }
                                break;
                            case 9:
                                if (tabela[2, 2] == "O" || tabela[2, 2] == "X")
                                {
                                    z = true;
                                }
                                else
                                if (tabela[2, 2] != "X")
                                {
                                    tabela[2, 2] = "O";
                                    z = false;
                                }
                                break;
                        }
                    }
                    cont = 0;

                    // VERIFICA EMPATE

                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[i, j] == "X" || tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                    }
                    if (cont == 9)
                    {
                        Console.Write("\n\n                O JOGO EMPATOU !!!\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }

                    // VARIFICA JOGO HORIZONTAL

                    cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                        if (cont == 3)
                        {
                            Console.Write("\n\n           JOGADOR 2 GANHOU HORIZONTAL\n\n");
                            op = 0;
                            break;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
               
                    // VARIFICA JOGO VERTICAL

                    cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[j, i] == "O")
                            {
                                cont++;
                            }
                        }
                        if (cont == 3)
                        {
                            Console.Write("\n\n           JOGADOR 2 GANHOU VERTICAL\n\n");
                            op = 0;
                            break;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                
                    // VARIFICA JOGO DIAGONAL DIREITA

                    cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (i == j)
                            {
                                if (tabela[i, j] == "O")
                                {
                                    cont++;
                                }
                            }
                        }
                    }
                    if (cont == 3)
                    {
                        Console.Write("\n\n           JOGADOR 2 GANHOU DIREITA\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }
                    // VARIFICA JOGO DIAGONAL ESQUERDA

                    cont = 0;
                    j = 2;
                    for (int i = 0; i < 3; i++)
                    {
                 
                        if (tabela[i, j] == "O")
                        {
                           cont++;
                           j --;
                        }
                    }
                    if (cont == 3)
                    {
                        Console.Write("\n\n           JOGADOR 2 GANHOU ESQUERDA\n\n");
                        op = 0;
                        break;
                    }
                    else
                    {
                        cont = 0;
                    }

                
                    cont = 0;
                }
            }
        }
    }
}