namespace Heranca
{
    public class Humano
    {

        // O Metodo virtual pode se assemelhar ao metodo abstract em alguns sentidos 
        // Exemplo ele é herdado e pode ser sobreescrito, porém o abstract ele so define
        // o metodo não tem nada dentro do metodo, ja o virtual podemos criar um metodo de base
        // e não obriga a ter o metodo na classe que esta herdado, mas podemos sobreescrever
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoa : Humano
    {
        // assim ele sobreescreve
        // Agora para eu travar um metodo para que ele não seja mais sobreescrito
        // Colocamos um novo atributo no metodo chamado sealed
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }
    
    class Homem : Pessoa
    {

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        } 
    }
    
}