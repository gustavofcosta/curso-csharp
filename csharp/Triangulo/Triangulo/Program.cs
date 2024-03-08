using System;
using Triangulo;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.CalcArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PÉRIMETRO = " + ret.CalcPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.CalcDiagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}