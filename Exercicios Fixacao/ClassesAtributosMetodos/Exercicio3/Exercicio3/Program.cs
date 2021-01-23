using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno = new Aluno();
            
            Console.WriteLine("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            aluno.N1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno.Resultado());

        }
    }
}
