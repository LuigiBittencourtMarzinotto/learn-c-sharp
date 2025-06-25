namespace Propriedades
{
    public class Pessoa
    {
        // Atributos de tipo privado
        //Por padrão os atributos de uma classe sempre fica privada a somente ela 
        private string _nome;
        private string _sobrenome;
        private int _idade;

        // Propriedades getter e setter
        // Para definir uma propriendade criamos da seguinte forma

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        // Diferente de funções a propriedades ela nao tem o uso de (), ou seja ao se chamada so chamamos o nome dela no caso "Nome"
        // Toda a manipulação é feita internamente com os atributos privados para que o user não tenha  acesso a esses atributos, tanto no set quanto no get podemos fazer 
        // manipulações ou condições antes do salvamento 
        // Exemplo
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Menor de idade");
                }
                else
                {
                    _idade = value;                    
                }
            }

        }
    }
}