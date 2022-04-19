namespace ConversorDolar
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 1.06;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total * Iof;
        }
    }
}
