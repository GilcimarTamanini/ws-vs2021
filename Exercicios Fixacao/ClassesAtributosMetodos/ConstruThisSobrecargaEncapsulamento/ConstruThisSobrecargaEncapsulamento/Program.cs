using System;
using System.Globalization;

namespace ConstruThisSobrecargaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o titular da conta : ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char inicial = char.Parse(Console.ReadLine().ToUpper());

            if (inicial == 'S')
            {
                Console.Write("Entre valor de deposisto inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("\r\nDados da conta:");

                conta = new Conta(titular, numConta, saldo);
                Console.Write(conta);
            }
            else
            {
                Console.WriteLine("\r\nDados da conta:");

                conta = new Conta(titular, numConta);
                Console.Write(conta);
            }

            Console.Write("\r\n\nEntre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados:");

            conta.Depositar(deposito);
            Console.Write(conta);

            Console.Write("\r\n\nEntre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados:");

            conta.Sacar(saque);
            Console.Write(conta);
        }
    }
}
