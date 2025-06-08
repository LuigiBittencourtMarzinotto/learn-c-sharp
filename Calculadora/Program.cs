namespace Calculadora;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro valor: ");
        double val1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double val2 = double.Parse(Console.ReadLine());
        
        Operacao:
        Console.Write("Digite a operação: ");
        char op = char.Parse(Console.ReadLine());
        double result = 0;
        switch (op)
        {
            case '*':
                result = val1 * val2;
                break;

            case '/':
                result = val1 / val2;
                break;

            case '+':
                result = val1 + val2;
                break;

            case '-':
                result = val1 - val2;
                break;

            default:
                Console.WriteLine("Operação não encontrada, informe novamente");
                goto Operacao;
        }

        Console.WriteLine("O resultado da operação deu: " + result);
    }
}