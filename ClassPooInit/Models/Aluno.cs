namespace ClassPooInit.Models
{
    public class Aluno : Pessoa
    {
        public double Score { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o aluno {Name} e tenho {Age} anos e minha maior nota é {Score}");
        }
        
    }

   
}