using FatorialRecursivo;

namespace FatorialRecurisvo;
class Program
{
    static void Main(string[] args)
    {
        Fatorial f = new Fatorial();
        int result = f.CalculoFatorial(8);
        Console.WriteLine("Resultado é : " + result);
    }
}