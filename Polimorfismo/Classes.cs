namespace Polimorfismo
{
    public class Forma
    {
        public int X { get; private set; } //Forma de encapsula direto da instanciação 
        public int Y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {

        }
    }


    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); //Podemos usar metodos ou instancias da classe mãe usando o base
            // Ou seja quase queramos reaproveitar um código da classe mãe ja feito podemos
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area Circulo " + area);
        }
    }


    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Retangulo");
        }

        public override void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Area Retangulo " + area);
        }
    }
    
    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); 
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            int area = (Largura * Altura) / 2 ;
            Console.WriteLine("Area Triangulo " + area);
        }
    }
}