
namespace Triangulo
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;
      

        public double CalcArea()
        {
            return Largura * Altura;
        }

        public double CalcPerimetro()
        {
            return 2 * (Largura + Altura); 
        }

        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(2, Largura) + Math.Pow(2, Altura));
        }
    }
}
