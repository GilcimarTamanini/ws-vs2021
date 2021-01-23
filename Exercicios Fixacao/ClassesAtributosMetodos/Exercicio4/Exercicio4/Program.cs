using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotacao do dolar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dolares voce vai comprar?");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorSerPago(dolar, cotacao).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
