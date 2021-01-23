using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;

            funcionario = new Funcionario();

            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);
            Console.WriteLine();

            Console.WriteLine("Digite porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
