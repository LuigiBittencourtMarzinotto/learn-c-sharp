namespace TermoThis;

class Program
{
    delegate void Operacao(int num1, int num2);

    static void Main(string[] args)
    {
        Matematica m = new Matematica();

        Operacao conta = null;
        conta += m.Somar;
        conta += m.Subtrair;
        conta += m.Divisao;
        conta(10, 2);
    }
}