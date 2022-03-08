using static System.Console;
using RpgProject.src.Entities;


namespace RpgProject
{
    class RpgGame
    {
        static void Main()
        {
            Knight Arus = new Knight("Arus", 12, "Knigth");
            Wizard Jenica = new Wizard("Jenica", 14, "White Wizard");
            

            WriteLine(Jenica.Attack(10));
            WriteLine(Arus.Attack());
        }

    }
      
}






