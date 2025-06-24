namespace MetodoConstrutor;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Console.WriteLine(p1.idade);

        // Como vimos dentro da classe criamos dois metodos construtores porem com assinaturas diferentes
        // e como um dos metodos construtores dependia de paramatros, para passar eles passamos na instanciação da classe
        Pessoa p2 = new Pessoa("Luigi", "Bittencourt", 20, 2004);
        Console.WriteLine(p2.idade);
    }
}

