using System;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor;
            string ultNome;
            int idade;
            float altura;
            
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
            vetor = Console.ReadLine().Split(' ');
            ultNome = vetor[0];
            idade = int.Parse(vetor[1]);
            altura = float.Parse(vetor[2]);

            Console.WriteLine(nome + " " + ultNome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
