using System.Text;

namespace exercicio02_arquivos_final
{
    class Arquivo
    {
        string nome, figurinha_faltante, figurinha_repetida;
        StreamWriter sw;
        StreamReader sr;
        public Arquivo(string nome)
        {
            this.nome = nome;
        }
        public void criaArquivoFigFaltantes()
        {
            sw = new StreamWriter("D:\\trabalhos_avmb\\Exercícios\\Exercícios_03 - Arquivos\\exercicio02-arquivos-final\\Faltantes\\" + nome + ".txt", true, Encoding.UTF8);
        }
        public void criaArquivoFigRepetidas()
        {
            sw = new StreamWriter("D:\\trabalhos_avmb\\Exercícios\\Exercícios_03 - Arquivos\\exercicio02-arquivos-final\\Repetidas\\" + nome + ".txt", true, Encoding.UTF8);
        }
        public void lerFigurinhasFaltantes()
        {
            string linha;
            sr = new StreamReader("D:\\trabalhos_avmb\\Exercícios\\Exercícios_03 - Arquivos\\exercicio02-arquivos-final\\Faltantes\\" + nome + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
        public void lerFigurinhasRepetidas()
        {
            string linha;
            sr = new StreamReader("D:\\trabalhos_avmb\\Exercícios\\Exercícios_03 - Arquivos\\exercicio02-arquivos-final\\Repetidas\\" + nome + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
        public void gravaFigurinhaFaltante(string figurinha_faltante)
        {
            sw.WriteLine(figurinha_faltante);
        }
        public void gravaFigurinhaRepetida(string figurinha_repetida)
        {
            sw.WriteLine(figurinha_repetida);
        }
        public void fechaArquivo()
        {
            sw.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, figurinha_faltante, figurinha_repetida;
            Console.WriteLine("Digite o nome do arquivo: ");
            nome = Console.ReadLine();
            Arquivo a = new Arquivo(nome);
            int op;
            while (true)
            {
                Console.WriteLine("Digite uma operação:" +
                    "\n1 - Cadastrar figurinha repetida\r" +
                    "\n2 - Cadastrar figurinha faltante\r" +
                    "\n3 - Listar figurinhas repetidas\r" +
                    "\n4 - Listar figurinhas faltantes\r" +
                    "\n5 - Sair\r" +
                    "\nOpção: ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (op == 1)
                {
                    a.criaArquivoFigRepetidas();
                    Console.WriteLine("Digite a figurinha repetida para ser armazenada: [codigo figurinha;seleçao;nome do jogador] \nPara sair, digite SAIR");
                    while (true)
                    {
                        figurinha_repetida = Console.ReadLine();
                        if (figurinha_repetida.Equals("SAIR"))
                        {
                            a.fechaArquivo();
                            break;
                        }
                        else
                        {
                            a.gravaFigurinhaRepetida(figurinha_repetida);
                        }
                    }
                }
                else if (op == 2)
                {
                    a.criaArquivoFigFaltantes();
                    Console.WriteLine("Digite a figurinha faltante para ser armazenada: [codigo figurinha;seleçao;nome do jogador] \nPara sair, digite SAIR");
                    while (true)
                    {
                        figurinha_faltante = Console.ReadLine();
                        if (figurinha_faltante.Equals("SAIR"))
                        {
                            a.fechaArquivo();
                            break;
                        }
                        else
                        {
                            a.gravaFigurinhaFaltante(figurinha_faltante);
                        }
                    }
                    Console.WriteLine();
                }
                else if (op == 3)
                {
                    a.lerFigurinhasRepetidas();
                    Console.WriteLine();
                }
                else if (op == 4)
                {
                    a.lerFigurinhasFaltantes();
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}