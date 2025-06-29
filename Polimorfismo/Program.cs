namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Forma a = new Forma();
        Forma b = new Triangulo(); //Podemos coloca que ele vai ser do tipo forma por conta que 
        // o triangulo herda da classe forma, só funciona se os mesmos metodos do triangulo tem em forma"
        // Caso o Triangulo tivesse metodos diferentes deveriamos colocar o tipo da classe como Triangulo"
        Forma c = new Circulo();
        Forma d = new Retangulo();

        a.Desenhar();
        Console.WriteLine("----------------------------------------");
        b.Desenhar();
        Console.WriteLine("----------------------------------------");
        c.Desenhar();
        Console.WriteLine("----------------------------------------");
        d.Desenhar();
    }
}