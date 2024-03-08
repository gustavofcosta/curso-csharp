
namespace LocatoraVeiculo.Entities
{
    internal class Carro : Veiculo
    {
        public Carro()
        {
            TaxaDiaria = 50;
        }
        public override double CalcularValorTotal(int numDiarias)
        {
            return TaxaDiaria * numDiarias;
        }
    }
}
