namespace Controle;

class Controle
{
    public static void Main(String[] args)
    {
        Inicio:
        Console.Write("Escolha uma numero:");
        int escolha = int.Parse(Console.ReadLine());
        
        // Label, quando colocamos na frente de uma frase um ":" significa que ela é um label, e podemos usar ela 
        // como endpoint para volta nela se quisermos
        switch (escolha)
        {
            case 0:
                Console.WriteLine("Escolha 0");
                break;

            case 1:
                Console.WriteLine("Escolha 1");
                break;

            case 2:
                Console.WriteLine("Escolha 2");
                goto case 1;
                // Tabém podemos fazer ele ir para outro case mesmo que o valor da variavel assistida pelo switch nao correponder
            default:
                Console.WriteLine("Escolha dnv");
                // o goto usamos como um modo de volta a algo ou entra, por exemplo
                // No caso a baixo fazemos ele volta a label inicio sendo o começo do nosso projeto
                goto Inicio;
                break;
        }
    }
}