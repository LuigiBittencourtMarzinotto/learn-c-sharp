namespace MetodoConstrutor;

public class Pessoa
{
    public string nome;
    public string sobrenome;
    public int anoNascimento;
    public int idade;

    // o metodo construtor ele é smp chamado na inicializaçõa da classe,
    // Ou seja assim que ele á instanciada dentro de um objeto o metodos construtor já chamado
    // O metodo construtor é o Metodo que tem o mesmo nome da classe, assim o programa entende q ele é o contrutor
    public Pessoa()
    {
        this.nome = "Desconhecido";
        this.sobrenome = "teste";
        this.anoNascimento = 04;
        this.idade = 24;

    }

    // Podemos criar varios metodos construtores, desde que mudemos suas assinaturas (ou seja acrescente ou diminua parametros)
    // Como o exemplo a baixo criamos uma nova assinatura para o mesmo metado construtor
    public Pessoa(string nome, string sobrenome, int idade, int anoNascimento)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.anoNascimento = anoNascimento;
        this.idade = idade;
    }
}
