namespace ClassPooInit.Models
{
    public class Professor : Pessoa
    {
        public double Wage {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Name} e tenho {Age} anos, e recebo R$ {Wage}");
        }
    }
}