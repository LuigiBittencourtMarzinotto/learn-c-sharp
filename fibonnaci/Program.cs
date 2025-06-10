namespace fibonnaci;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("################# FIBONACCI #################");
        Console.Write("Escolha um número: ");
        int value = int.Parse(Console.ReadLine());
        int soma = 0;
        int[] arrayValues = new int[value];
        arrayValues[0] = 0;
        arrayValues[1] = 1;

        for (int i = 2; i < value; i++)
        {
            arrayValues[i] = arrayValues[i - 1] + arrayValues[i - 2];
        }
        Console.WriteLine("O valor é " + arrayValues[value - 1]);
    }
}