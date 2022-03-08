using static System.Console;
using RpgPokemon.src.Perfil;
using System.Threading.Tasks;


//using static RpgPokemon.src.Entity;

namespace RpgPokemon.src.Entity    //SEMPRE O NOME DO ARQUIVO NO PRINCIPAL  E DO CAMINHO NOS DEMAIS
{    
    class Pokemon
    {
        static void Main()
        {
            Helper helper = new Helper();
            Trainer Protagonista = new Trainer();
            
            Console.Clear();
            WriteLine("Olá Treinador, bem vindo ao mundo Pokémon...");
            helper.Continue();
            WriteLine("É um mundo fantastico!!! Cheio de criaturas mistériosas.");
            helper.Continue();
            WriteLine("Vamos começar, mas antes de tudo...");
            helper.Continue();
            
            WriteLine("Você é um [Garoto] ou uma [Garota]?");
            string? sexoTrainer = ReadLine();

            sexoTrainer = sexoTrainer.ToLower();
        
            while(sexoTrainer!= "garoto" && sexoTrainer != "garota")
            {
                Console.Clear();
                WriteLine("Por Favor, digite [Garoto] ou [Garota]");
                sexoTrainer = ReadLine();
                Console.Clear();
            }

            if(sexoTrainer == "garoto")
            {
                Console.Clear();
                WriteLine("claro que é um garoto, como eu sou bobo...");   
                helper.Continue(); 
            }
            else
            {
                Console.Clear();
                WriteLine("Uma garota, é claro! haha");
                helper.Continue();
            }

            WriteLine("Eu me chamo Professor Carvalho, e vou te acompanhar nessa incrível jornada!");
            helper.Continue();
            WriteLine("Já ia me esquecendo... Qual é mesmo seu nome?");
            Protagonista.Name = ReadLine();
            
            while(Protagonista.Name == "")
            {
                Console.Clear();
                WriteLine("Desculpe, Qual o seu nome?");
                Protagonista.Name = ReadLine();
            }
            Console.Clear();
            WriteLine($"Oh, então você se chama {Protagonista.Name}.");
            
            helper.Continue();


            




        }

    }
}

// HP ATK DEF LVL TYPE NATURE ITEM