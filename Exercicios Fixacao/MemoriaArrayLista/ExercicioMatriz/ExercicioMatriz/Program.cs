using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int x = 0; x < m; x++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int y = 0; y < n; y++)
                {
                    matriz[x, y] = int.Parse(valor[y]);
                }
            }

            Console.WriteLine("Digite um numero da matriz: ");
            int numMat = int.Parse(Console.ReadLine());

            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (matriz[x, y] == numMat)
                    {
                        Console.WriteLine("Posicao: " + x + "," + y);

                        if (y > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[x, y - 1]);
                        }
                        if (x > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[x - 1, y]);
                        }
                        if (y < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[x, y + 1]);
                        }
                        if (x < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[x + 1, y]);
                        }
                        
                    }
                }
            }
        }
    }
}
