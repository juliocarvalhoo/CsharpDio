using static System.Console;
public class Programa
{
    static int Adicionar20(int x)
    {
    return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static void Demo()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();
        //Pessoa p2 = new Pessoa();  //metetódo mais trabalhoso
        //p2.Nome = p1.Nome;
        //p2.Idade = p1.Idade;
        //p2.Documento = p1.Documento;
        

        TrocarNome(p1,"José");

        WriteLine($@"
        O nome de p1 é : {p1.Nome}
        O nome de p2 é : {p2.Nome}
        ");

    }
    public static void Main()
    {
        Demo();
    }
}
