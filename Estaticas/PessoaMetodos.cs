namespace Estaticas
{
    partial class Pessoa
    {
        public void Apresentacao()
        {
            Console.WriteLine("Olá " + nome);
        }

        public static int CalculaIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}