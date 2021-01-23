using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudante = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine("Rent #" + i.ToString());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numQuarto = int.Parse(Console.ReadLine());

                estudante[numQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i.ToString() + ": " + estudante[i]);
                }
            }

        }
    }
}
