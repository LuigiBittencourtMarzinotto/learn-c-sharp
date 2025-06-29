namespace Heranca
{
    // Para herda uma classe colocamos : e o nome da mesma na frente
    public class Motocicle() : Automovel
    {
        // Para colocar o metodo que a classe mae obrigou suas flihas ter
        // Devemos colocar o atributo override para indica que ela vai sobreescrever o metodo da classe mae
        
        public override void Acelerar()
        {
            Console.WriteLine("Moto Acelerou");
        }

    }
}