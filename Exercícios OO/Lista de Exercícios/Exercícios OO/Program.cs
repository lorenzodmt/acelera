namespace Exercícios_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04 - Pessoa
            /*
            Pessoa pes = new Pessoa();
            Console.WriteLine("CADASTRO:");
            Console.WriteLine("Nome: ");
            pes.nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            pes.cpf = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            pes.dataNasc = Console.ReadLine();
            Console.WriteLine("RG: ");
            pes.rg = Console.ReadLine();
            Console.WriteLine("Estado Civil: ");
            pes.estadoCivil = Console.ReadLine();

            Console.WriteLine("---------------------");
            Console.WriteLine($"Nome: {pes.cadastroNome()}");
            Console.WriteLine($"CPF: {pes.cadastroCpf()}");
            Console.WriteLine($"Data de nascimento: {pes.cadastroDataNasc()}");
            Console.WriteLine($"RG: {pes.cadastroRg()}");
            Console.WriteLine($"Estado Civil: {pes.cadastroEstadoCivil()}");
            Console.WriteLine("---------------------");
            */



            //05 - Livro
            /*
            Livro l1 = new Livro(987654, "As aventuras de PI", 2999, "Editora Legal", "O próprio PI", "Aventura");
            */

            //06 - Aluno
            /*
            Aluno a1 = new Aluno(1234, 2002, "Lorenzo", "Rua dos Bobos Nº 0", "(55) 99988-7766");
            */


            //07 - Personagem
            /*
            Personagem p1 = new Personagem();
            p1.nome = "Lorenzo";
            p1.posicao = 0;
            p1.posicao_final = 10;
            Console.WriteLine("SELECIONE UMA OPÇÃO:");            
            Console.WriteLine("1 - Andar (avança 1 casa e perde 2 de vida)");
            Console.WriteLine("2 - Voltar (retrocede 1 casa, ganha 3 de vida e recebe 1 item de cura)");
            Console.WriteLine("3 - Curar (consome 1 item de cura e recebe 1 de vida)");
            int opcao = int.Parse(Console.ReadLine());            
            
            //se dentro de um laço de repetição (while), jogo continua até o personagem morrer
            if (opcao == 1)
            {
                p1.andar();
            }
            else if (opcao == 2)
            {
                p1.voltar();
            }
            else if (opcao == 3)
            {
                p1.curar();
            }
            */



            //08 - Funcionario
            /*
            Funcionario f1 = new Funcionario(000000000, "24/12/1800", 80028922, "Dom Lorenzo Cabral Independencia da Silva", "Portugal, Rua da Capitania Hereditária");
            Console.WriteLine("Funcionario: ");
            Console.WriteLine("CPF: " + f1.cpf);
            Console.WriteLine("Nome: " + f1.nome);
            Console.WriteLine("Data de nascimento: " + f1.dataNasc);
            Console.WriteLine("RG: " + f1.rg);
            Console.WriteLine("Endereço: " + f1.endereco);
            */



            //09 - Motor
            /*
            Motor m1 = new Motor();
            m1.Associar();
            Console.WriteLine("Características do Motor:");
            Console.WriteLine("Nome da fabricante: " + m1.RetornarNomeFabricante());
            Console.WriteLine("Potência: " + m1.RetornarPotencia());
            Console.WriteLine("Tipo: " + m1.RetornarTipo());
            */


        }
    }
}