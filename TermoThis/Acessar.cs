namespace TermoThis;

public class Acessar
{
    string senha = "1234";

    public bool Login(string senha)
    {
        // this faz referencia a classe ou seja com ele podemos trazer tantas as variaveis que esão na clase
        // Tanto chamar os metodos 
        return this.senha == senha;
    }
}
