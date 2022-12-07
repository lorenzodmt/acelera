namespace Exercícios_06___Orientação_ao_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 04 Pessoa
            
            Pessoa pes = new Pessoa("lorenzo", "123456789", "24/12/1800", "1120200000", "Solteiro");
                
            Console.WriteLine($"Nome: {pes.nome}");                
            Console.WriteLine($"CPF: {pes.cpf}");                
            Console.WriteLine($"Data de nascimento: {pes.dataNasc}");                
            Console.WriteLine($"RG: {pes.rg}");                                
            Console.WriteLine($"Estado Civil: {pes.estadoCivil}");


            //Personagem
            /*
            Personagem p1 = new Personagem();
            Console.WriteLine("SELECIONE UMA OPÇÃO:");
            Console.WriteLine("1 - Andar (avança 1 casa e perde 2 de vida)");
            Console.WriteLine("2 - Voltar (retrocede 1 casa, ganha 3 de vida e recebe 1 item de cura)");
            Console.WriteLine("3 - Curar (consome 1 item de cura e recebe 1 de vida)");
            p1.opcao = int.Parse(Console.ReadLine());

            if (p1.opcao == 1)
            {
                p1.andar();
            }
            if (p1.opcao == 2)
            {
                p1.voltar();
            }
            if (p1.opcao == 3)
            {
                p1.curar();
            }
            */
        }
    }
}