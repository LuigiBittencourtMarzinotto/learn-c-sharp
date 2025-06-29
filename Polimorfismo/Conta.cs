namespace Polimorfismo
{
    public class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        public void Saldo()
        {
            
        }
    }

    // Padrão de nomeclatura é coloca o I maiusculo antes do nome para indica que é uma interface
    interface IConta
    {
        // Todos os dados por padrão deve ser publicos para que as classes podem extender elas

        string Usuario { get; set; }

        // Como por padrao todos os metodos dentro de uma interface ja estão como abstrato, ent nao tem pq colocar
        void Depositar();
        void Sacar();
        void Saldo();
    }
}