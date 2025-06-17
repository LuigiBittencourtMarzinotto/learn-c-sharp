namespace TypeOfMethodByClass;

class Program
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        m.Cumprimentar();
        m.Somar(10, 5);
        int valor = 20;

        // para passa o parametro necessitamos indica que ao passa ele deve passa a ref nao uma copia
        m.AumentarValorRef(ref valor);
        Console.WriteLine(valor);

    }
}