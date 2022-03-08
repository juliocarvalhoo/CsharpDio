
namespace ClassPooInit.Models
{
    public class Pessoa
    {
        public string? Name {get;set;}

        public int Age {get;set;}

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Name} e tenho {Age} anos");
        }
    }
}