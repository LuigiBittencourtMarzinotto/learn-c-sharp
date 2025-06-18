namespace TypeOfMethodByClass;

public class Methods
{
    public void Cumprimentar()
    {
        Console.WriteLine("Praze em lhe conhecer ");
    }

    // Metodos com parametros
    // recebemos parametros de varios tipos conhecidos
    public void Somar(int val1, int val2)
    {
        Console.WriteLine("soma: " + (val1 + val2));
    }

    // Passagem de parâmetros por referência
    // parâmetros por referencias fazem com que recebemos a variavel real, não uma copia dela, sendo assim
    // se alterada dentro de uma função sem o ref seu valor real não sera alterado, ja com o ref ele sera alterado
    // Exemplo

    public void AumentarValorRef(ref int valor)
    {
        valor += 10;
    }

    // Metodos com retorno de valores
    // Todo metodo pode ter ou não um retorno, porém antes do retorna ja devemos sinaliza que tipo de dado
    // ele tem q retorna, o tipo de retorno é obrigatorio ser igual o tipo sinalizado depois do public
    public string MontaNome(string nome, string sobrenome)
    {
        return nome + " " + sobrenome;
    }

    // Sobrecarga de metodos
    // Toda função tem uma assinatura, ou seja da forma q ela é construida ela gera uma assinatura, carecterizado por seus parametros e tipos
    // Na sobrecarga de metodos podemos criar uma função o mesmo nome de uma ja criada, desde que mudemos seus parametros ou quantidade ou tipos
    // Exemplo:
    public void teste1()
    {
        Console.WriteLine("Teste");
    }

    public void teste1(string name)
    {
        Console.WriteLine("Teste do " + name);
    }
}



