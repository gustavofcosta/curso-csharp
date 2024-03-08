using LocatoraVeiculo.Entities;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            int numDiarias = 10;

            Console.WriteLine($"O valor total de carro para ({numDiarias} diárias): R${carro.CalcularValorTotal(numDiarias)}");
            Console.WriteLine($"O valor total de moto para ({numDiarias} diárias): R${moto.CalcularValorTotal(numDiarias)}");
        }
    }
}