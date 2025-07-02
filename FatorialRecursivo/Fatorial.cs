using System.Globalization;

namespace FatorialRecursivo
{
    public class Fatorial
    {
        public int CalculoFatorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            return n * CalculoFatorial(n - 1); ;
        }
    }
}