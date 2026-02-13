using System.Globalization;
using System.Collections.Generic;

namespace IntroducaoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            Console.Clear();
            Console.WriteLine("=== Sistema da Escola Mundo Melhor ===");
            Console.Write("Qual o seu nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo {nomeUsuario}");

            Console.Write("Quantos alunos serão cadastrados? ");
            int quantidadeCadastro = Convert.ToInt16(Console.ReadLine());

            for (int repetir = 1; repetir <= quantidadeCadastro; repetir++)
            {
                var aluno = new Aluno();                

                Console.WriteLine($"\nCadastro do aluno: {repetir}:");

                Console.Write("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Qual a matrícula do aluno: ");
                aluno.Matricula = Console.ReadLine();

                double[] notas = new double[3];
                for (int index = 0; index < notas.Length; index++)
                {
                    Console.Write($"Nota {index + 1}: ");
                    aluno.Notas.Add(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));
                }
                alunos.Add(aluno);
                
            }

            Console.WriteLine("\n=== Alunos cadastrados ===");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.Write("Notas: ");

                double soma = 0;
                foreach (var nota in aluno.Notas)
                {
                    Console.Write(nota.ToString("F1", CultureInfo.InvariantCulture) + " ");
                    soma += nota;
                }

                
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matricúla: {aluno.Matricula}");               
                Console.WriteLine($"Notas: {string.Join(",", aluno.Notas.ToArray())}");
                Console.WriteLine($"Media: {aluno.CalcularMedia().ToString("F1",CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Situação: {aluno.Situacao()}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
