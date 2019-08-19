using System;
using System.Globalization;

namespace ExContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            char Resp = char.Parse(Console.ReadLine());

            if (Resp == 's' || Resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados!");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados!");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Acesso encerrado!");
        }
    }
}
