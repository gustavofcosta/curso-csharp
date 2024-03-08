
namespace LocatoraVeiculo.Entities
{
    internal class Moto: Veiculo
    {
        public Moto()
        {
            TaxaDiaria = 25;
        }

        public override double CalcularValorTotal(int numDiarias)
        {
            return TaxaDiaria * numDiarias;
        }
    }
}
