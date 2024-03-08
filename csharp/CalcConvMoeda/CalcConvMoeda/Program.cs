using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("quantos dólares vocÊ vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser paga em reais = " + CalcConvMoeda.Calc.CalcDol(cotacao, qtdDolar).ToString("F2") );
        }
    }
}