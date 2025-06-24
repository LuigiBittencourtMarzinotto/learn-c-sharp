using HelloWorld.teste;
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        #region comentario de teste
        Console.WriteLine("Eu te amo Leticia muito");
        Car meuCarro = new Car();
        meuCarro.Ligar();
        Moto meuMoto = new Moto();
        meuMoto.Acelerar();
        #endregion

        int value = 150;
        int soma = 0;
        string valueString = value.ToString();
        for (int i = 0; i < value.ToString().Length; i++)
        {
            soma += (int)Math.Pow(int.Parse(valueString[i].ToString()), valueString.Length);
        }
        Console.WriteLine(soma == value);
    }
}