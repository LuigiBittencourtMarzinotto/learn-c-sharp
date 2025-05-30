namespace EntradaSaida;

class EntradaSaida
{
    public static void Main(string[] args)
    {
        Console.WriteLine("################## TESTE DE ENTRADA ##################");
        Console.Write("Quantos anos vc tem? ");
        string? input = Console.ReadLine();
        // pega o que foi escrito
        Console.Write("QuUal tecla vc qr? ");

        int inputInt = Console.Read();
        Console.WriteLine("O valor da tecla é: " + inputInt);

        Console.WriteLine(input);

        Console.WriteLine("################## TAREFA DE INVERSÂO DE NOME ##################");
        string[] names = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o nome " + i);
            string? readInput = Console.ReadLine();
            names[i] = readInput ?? "";
        }

        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine("Nome " + i + " - " + names[i]);
        }
    }
}

