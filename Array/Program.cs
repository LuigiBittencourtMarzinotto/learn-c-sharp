namespace Array;

class Array
{
    public static void Main(string[] args)
    {
        // int numero = 0;

        // vetor
        // dentro do [] colocamos quantos indices esse vetor vai ter, caso passe ele retornara um erro
        int[] numeros = new int[5];

        // para colocar valor vamos da seguinte forma
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;
        // neles podemos reescrever os valores, so re-chama a variavel com o indice com o novo valor
        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }

        // podemos fazer de varios tipos, qualquer tipo de variavel da para se criar com um array, ex com string
        string[] nomes = new string[3];
        nomes[0] = "Luigi";
        nomes[1] = "Bittencourt";
        nomes[2] = "Marzinotto";

        // podemos criar tbm da seguinte forma, quando não sabemos o tamanho do vetor podemos criar da seguinte forma
        string[] nomes2 =
        {
            "Luigi 2",
            "Bittencourt 2",
            "Marzinotto 2",
        };

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }


        // Array bidimensional - vetores temos linhas e colunas 
        // [linha, coluna]
        int[,] vetor_numeros = new int[2, 3];

        vetor_numeros[0, 0] = 10;
        vetor_numeros[0, 1] = 20;
        vetor_numeros[0, 2] = 30;


        vetor_numeros[1, 0] = 40;
        vetor_numeros[1, 1] = 50;
        vetor_numeros[1, 2] = 60;

        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                Console.Write("[ " + vetor_numeros[i, j] + " ] ");
            }
            Console.WriteLine();
            
        }
    }
}