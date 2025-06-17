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
}



