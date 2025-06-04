namespace CalcularIMC;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o peso em kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Informe sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double resultIMC = peso / (altura * altura);

        if (resultIMC < 20)
        {
            Console.WriteLine("\nVocê esta abaixo do peso, seu IMC " + resultIMC);
        }
        else if (resultIMC >= 20 && resultIMC <= 24)
        {
            Console.WriteLine("\nVocê pesa normal, seu IMC " + resultIMC);
        }
        else if (resultIMC >= 25 && resultIMC <= 29)
        {
            Console.WriteLine("\nVocê esta acima do peso, seu IMC " + resultIMC);
        }
        else if (resultIMC >= 30 && resultIMC <= 34)
        {
            Console.WriteLine("\nVocê esta acima obeso, seu IMC " + resultIMC);
        }
        else
        {
            Console.WriteLine("\nVocê esta parecendo plutão, seu IMC " + resultIMC);
        }
    }
}