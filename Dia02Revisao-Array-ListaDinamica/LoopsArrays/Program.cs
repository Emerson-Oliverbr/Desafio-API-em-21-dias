using System.Collections.Generic;

namespace LoopsArrays;
class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("Digite o numero inicial: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero inicial: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------");
        for(int i = numero1; i <= numero2; i+=1)
        {
            Console.WriteLine($"Numero: {i}");
        }*/    

        /*
        int[] itens = new int[] {1,2,3,4,5,6,7,8,9,10};
        
        foreach(int item in itens)
        {
            Console.WriteLine($"Numero: {item}");
        }        */

        
        /*while(true)
        {
            Console.WriteLine("Digite\n 1 - para sair\n 0 - para continuar");
            int sair = int.Parse(Console.ReadLine());
            if(sair == 1) break;
            else if(sair ==2) continue;

            Console.WriteLine("Estou aqui");
        }*/

        List<dynamic> alunos = new List<dynamic>();
        alunos.Add( new
        {
            Nome = "Emerson",
            Matricula = "001",
            Notas = "10.0, 9.5"
        });

        alunos.Add( new
        {
            Nome = "Laudhelina",
            Matricula = "002",
            Notas = "10.0, 9.5"
        });
       
        foreach(var aluno in alunos)
        {      
            Console.WriteLine("------------------");      
            Console.WriteLine($"Nome: {aluno.Nome}, \nmatricula: {aluno.Matricula}, \nNotas: {aluno.Notas}");               
        }         
     }
}

