namespace Recursividade
{
    public class Recursivo
    {
        public void Executar(String mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        public void ExecutarRecursivo(String mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem + " " + n);
                ExecutarRecursivo(mensagem, n - 1);
            }
        }
    }
}