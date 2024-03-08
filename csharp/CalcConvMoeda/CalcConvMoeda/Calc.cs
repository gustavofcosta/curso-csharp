namespace CalcConvMoeda
{
    internal class Calc
    {
        public static double Iof = 0.06;

        public static double CalcDol(double cot, double dol)
        {
            return  ( cot * dol) * Iof + (cot * dol);
        }
    }
}
