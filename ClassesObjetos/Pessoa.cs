namespace ClassesObjetos;

public class Pessoa
{
    // Atributos de uma classe, nela podemos alterar ou acessar
    // 
    public string nome;
    public string cpf;
    public int idade;

    // Função void sem retorno
    public void Cumprimentar()
    {
        Console.WriteLine("Praze em lhe conhecer " + nome + "" + cpf);
    }
}
