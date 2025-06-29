namespace Heranca
{
    abstract public class Automovel
    {
        private double _motor;
        private string _marca;
        private string _modelo;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public double Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        abstract public void Acelerar();

        public void Parar()
        {
            Console.WriteLine("Parou");
        }
    }
}