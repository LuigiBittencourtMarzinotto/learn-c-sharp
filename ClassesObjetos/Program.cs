namespace ClassesObjetos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        NewClass newClass = new NewClass();
        // depoios de ter instanciado uma classe podemos acessa os atributos dela
        // na variavel que criamos, temos acessos a todos seus atributos, podemos manipular eles
        pessoa.nome = "Luigi";
        pessoa.cpf = "07964089986";
        pessoa.idade = 15;

        // Podemos tbm na sua intanciação ja coloca seus atributos 
        // Facilitando assim implementação de valores nos atributos
        Pessoa p2 = new Pessoa()
        {
            nome = "Leticia",
            cpf = "04350852595",
            idade = 18,
        };

    }
}
