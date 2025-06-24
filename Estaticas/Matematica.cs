namespace Estaticas
{
    // Classe estatica, todos os membros devem ser estatico
    // Ou seja não dependem de uma instanciação dentro de um objeto
    // Quando uma classe é estatica tudo dentro dela deve ser tbm
    static class Matematica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}