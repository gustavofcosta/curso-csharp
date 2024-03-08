using ContaBancaria;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Extrato extrato;

            Console.Write("Entre o número da conta: ");
            int acount = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? : ");
            char hasInitialDeposit = char.Parse(Console.ReadLine());

            if (hasInitialDeposit == 's' || hasInitialDeposit == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoinitial = double.Parse(Console.ReadLine());
                extrato = new Extrato(name, acount, depositoinitial);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(extrato);
            } else
            {
                extrato = new Extrato(name, acount);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(extrato);
            }
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            extrato.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(extrato);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            extrato.Saque(saque);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(extrato);
        }
    }
}