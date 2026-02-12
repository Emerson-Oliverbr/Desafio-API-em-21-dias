using System.Globalization;
using System.Collections.Generic;

namespace IntroducaoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> alunos = new List<dynamic>();

            Console.Clear();
            Console.WriteLine("=== Sistema da Escola Mundo Melhor ===");
            Console.Write("Qual o seu nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo {nomeUsuario}");

            Console.Write("Quantos alunos serão cadastrados? ");
            int quantidadeCadastro = Convert.ToInt16(Console.ReadLine());

            for (int repetir = 1; repetir <= quantidadeCadastro; repetir++)
            {
                Console.WriteLine($"\nCadastro do aluno: {repetir}:");

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Qual a matrícula do aluno: ");
                int matricula = Convert.ToInt16(Console.ReadLine());

                double[] notas = new double[3];
                for (int index = 0; index < notas.Length; index++)
                {
                    Console.Write($"Nota {index + 1}: ");
                    notas[index] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                
                alunos.Add(new { 
                    Nome = nome,
                    Matricula = matricula, 
                    Notas = notas 
                });
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

                double media = soma / aluno.Notas.Length;
                Console.WriteLine($"\nMédia: {media.ToString("F1", CultureInfo.InvariantCulture)}");

                if (media >= 7.0)
                {
                    Console.WriteLine("Situação: Aprovado");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado");
                }

                Console.WriteLine("---------------------------");
            }
        }
    }
}
