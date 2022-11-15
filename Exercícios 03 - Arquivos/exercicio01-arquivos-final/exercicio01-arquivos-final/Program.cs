using System.Text;

namespace exercicio01_arquivos_final
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int resp = 0;
            string email, line;
            while (resp != 3)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Listar");
                Console.WriteLine("3- Sair");
                Console.WriteLine("Digite a opção desejada");
                resp = int.Parse(Console.ReadLine());
                try
                {

                    if (resp == 1)
                    {
                        Console.WriteLine("Digite o e-mail que deseja cadastrar:");
                        email = Console.ReadLine();
                        StreamWriter a;
                        a = new StreamWriter("cadastroemail.txt", true, Encoding.UTF8);
                        a.WriteLine(email);
                        a.Close();
                    }
                    if (resp == 2)
                    {
                        StreamReader a = new StreamReader("cadastroemail.txt");
                        line = a.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = a.ReadLine();
                        }
                        a.Close();
                    }


                }
                finally
                {


                }
            }
        }
    }
}
