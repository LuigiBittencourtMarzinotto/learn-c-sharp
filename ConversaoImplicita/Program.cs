namespace ConversaoImplicita;

class ConversaoImplicita
{
    public static void Main(string[] args)
    {
        // int numero = 343443;

        // // Passando str para a familia dos numeros
        // // EXEMPLOS
        // string ex1 = "123";
        // int numexp1 = int.Parse(ex1);
        // Console.WriteLine(numero);

        // string ex2 = "34,0900";
        // double numero2 = double.Parse(ex2);
        // Console.WriteLine(numero2);

        // string ex3 = "34,01";
        // float numero3 = float.Parse(ex3);
        // Console.WriteLine(numero3);

        string numero = Convert.ToString(15);
        Console.WriteLine(numero);

        int frase = Convert.ToInt32("C");
        Console.WriteLine(frase);

    }
}