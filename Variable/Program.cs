namespace Variable;
class Program
{
    enum DiaDaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }

    struct Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
    }

    static void Main(string[] args)
    {
        int numberTest = 0;
        Console.WriteLine("Tipos Inteiro: " + numberTest);

        float numberFloat = 98.25f; //por padrão o valor do float tem que ter o f no final do valor
        Console.WriteLine("Tipos Float: " + numberFloat);

        Double numberDouble = 9801.25;
        Console.WriteLine("Tipos Double: " + numberDouble);


        decimal numberDecimal = 756565.25m; //por padrão o valor do float tem que ter o m no final do valor
        Console.WriteLine("Tipos Float: " + numberDecimal);

        char word = 'L';
        Console.WriteLine("Tipos Char: " + word);

        bool DoYouLoveMe = true;
        Console.WriteLine("Tipos Bolean: " + DoYouLoveMe);

        string ask = "Do you live with me?";
        Console.WriteLine("Tipo String: " + ask);

        var noneType = "String Type";
        Console.WriteLine("None type: " + noneType);

        object ObjectType = 324;
        Console.WriteLine("Object type: " + ObjectType);

        const string askType = "ererewr";
        Console.WriteLine(askType);
        Console.WriteLine(DiaDaSemana.Quarta);

        Pessoa p1 = new Pessoa();
        p1.nome = "Luigi";
        p1.idade = 20;
        p1.altura = 1.75;
        Console.WriteLine(p1.nome);
        Console.WriteLine(p1.idade);
        Console.WriteLine(p1.altura);
    }
}