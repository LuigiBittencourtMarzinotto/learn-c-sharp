namespace repeticao;

class Repeticao
{
    public static void Main(string[] args)
    {
        // Laço de repetição while 
        int value = 0;
        do
        {
            Console.WriteLine("Dentro do laço " + value);
            value++;
        }
        while (value < 10);
    
        
        Console.WriteLine("Fora do laço");
    }
}