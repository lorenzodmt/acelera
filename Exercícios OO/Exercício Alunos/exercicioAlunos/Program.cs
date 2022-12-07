using exercicioAlunos.DataModels;
using Microsoft.EntityFrameworkCore;

namespace exercicioAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                "1 para cadastrar um aluno\n" +
                "2 para alterar o nome do aluno\n" +
                "3 para inserir um curso\n" +
                "4 para excluir um aluno\n" +
                "5 para consultar tudo\n" +
                "6 para consultar pelo ID\n");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Inserir o nome do aluno:");
                        Alunos p = new Alunos();
                        p.nome = Console.ReadLine();

                        Console.WriteLine("Informe um curso:");
                        string cursosTemp = Console.ReadLine();

                        p.Cursos = new List<Cursos>()
                        {
                            new Cursos()
                            {
                                curso = cursosTemp
                            }
                        };

                        contexto.Alunos.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Aluno inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID do aluno:");
                        int id = int.Parse(Console.ReadLine());

                        Alunos pAlt = contexto.Alunos.Find(id);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.nome = Console.ReadLine();

                        contexto.Alunos.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID do aluno:");
                        int id = int.Parse(Console.ReadLine());
                        Alunos p = contexto.Alunos.Find(id);

                        Console.WriteLine("Informe o novo Curso:");
                        string cursosTemp = Console.ReadLine();

                        p.Cursos = new List<Cursos>()
                        {
                            new Cursos()
                            {
                                curso = cursosTemp
                            }
                        };

                        contexto.Alunos.Update(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID do aluno:");
                        int id = int.Parse(Console.ReadLine());
                        Alunos p = contexto.Alunos.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.nome);
                        Console.WriteLine("E dos seus cursos:");

                        foreach (Cursos item in p.Cursos)
                        {
                            Console.WriteLine("\t" + item.curso);
                        }

                        Console.WriteLine("1 para SIM e outra tecla para NÃO");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Alunos.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.nome + " excluída com sucesso!");
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 5:
                    try
                    {
                        List<Alunos> lista = (from Alunos p in contexto.Alunos
                                              select p).Include(pes => pes.Cursos).ToList<Alunos>();

                        foreach (Alunos item in lista)
                        {
                            Console.WriteLine(item.nome);

                            foreach (Cursos itemE in item.Cursos)
                            {
                                Console.WriteLine("\t" + itemE.curso);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int idAluno = int.Parse(Console.ReadLine());
                        Alunos aluno = contexto.Alunos
                            .Include(p => p.Cursos)
                            .FirstOrDefault(x => x.Id == idAluno);
                        Console.WriteLine(aluno.nome);

                        if (aluno.Cursos != null)
                        {
                            foreach (Cursos item in aluno.Cursos)
                            {
                                Console.WriteLine("    " + item.curso);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }
}