namespace Estaticas;

class Program
{
    static void Main(string[] args)
    {
        // Como é uma classe estatica, podemos muda o valor de seus atributos sem depender de uma instancia do objeto
        // como no exemplo a baixo que manipulamos um atributo da class
        Matematica.taxa = 10;

        // como o valor do atributo mudo tudo oq depende dele se basear pelo valor alterado, ele não é mais um por objeto
        // mas sim um global

        int valor1 = Matematica.Adicionar(200);
        int valor2 = Matematica.Diminuir(200);

        Console.WriteLine(valor1);
        Console.WriteLine(valor2);

        // Acessamos um atributo estatico sem necessidade de instanciação de uma objeto da classe
        Console.WriteLine(Pessoa.maiorIdade);

        Pessoa p1 = new Pessoa();
        p1.nome = "Luigi";
        // Metodo estatico
        p1.idade = Pessoa.CalculaIdade(2004);
        Console.WriteLine(p1.idade);
    }
}