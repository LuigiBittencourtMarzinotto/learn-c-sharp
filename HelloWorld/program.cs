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
    }
}