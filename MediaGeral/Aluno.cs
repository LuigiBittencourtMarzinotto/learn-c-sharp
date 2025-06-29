namespace MediaGeral
{
    public class Aluno
    {
        public string Nome { get; private set; }
        private double[] _notas;

        // ao trazer esse atributo ele vai trazer o encapsulamento get
        // e nele temos o controle para poder chamar um metodo do mesmo tipo e que retorna o mesmo tipo 
        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Valor da nota da Prova " + (i + 1) + " : ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;

            foreach (var item in _notas)
            {
                total += item;
            }

            return total / _notas.Length;
        }
    }
}