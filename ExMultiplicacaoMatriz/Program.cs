namespace ExMultipicacaoMatriz;

class ExMultipicacaoMatriz
{
    public static void Main()
    {
        int[,] vetor_2_3 = {
            {1, 2, 3},
            {5, 6, 7}

        };

        int[,] vetor_3_2 = {
            {1, 2},
            {3, 4},
            {5, 6},
        };

        int[,] resultado = new int[2, 2];
        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
                int soma = 0;
                for (int k = 0; k < 3; k++) 
                {
                    soma += vetor_2_3[i, k] * vetor_3_2[k, j];
                }
                resultado[i, j] = soma;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}