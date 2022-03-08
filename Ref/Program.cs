using static System.Console;
referencia.Iniciar();
class referencia
{
    static void Demo1()
    {
        int a = 5;
        adicionar20(ref a);
        WriteLine($"O valor de a é {a}"!);
    }
    
    static void Demo2()
    {
        var nomes = new string[] {"XANDAO", "THIAGUERA", "CARECAPAULO", "SUPERJULIO"};
        WriteLine("Insira o nome que deseja trocar: ");
        var nome = ReadLine();
        WriteLine("Insira o nome novo: ");
        var NomeNovo = ReadLine();

        AlterarNome(nomes, nome, NomeNovo);

        WriteLine("\n");
        WriteLine(string.Join("\n",nomes));
    }

    static void Demo3()
    {
        var nomes = new string[] {"XANDAO", "THIAGUERA", "CARECAPAULO", "SUPERJULIO"};
        WriteLine("Insira o nome que deseja trocar: ");
        var nome = ReadLine();
        WriteLine("Insira o nome novo: ");
        var NomeNovo = ReadLine();

        var indice = LocalizarNome(nomes,nome);

        if (indice >=0)
        {
            nomes[indice] = NomeNovo;
            WriteLine("\n");
            WriteLine(string.Join("\n",nomes));

        }
        else 
        {
            WriteLine("Nome não encontrado");
        }


        
    }

    static int LocalizarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
                return i;                    
        }

        return -1;

    }
    static void AlterarNome(string[] nomes, string nome, string NomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = NomeNovo;
            }
            
        }
    }

    static void adicionar20(ref int a)
    {
        a += 20;
    }

    public static void Iniciar()
    {
        Demo3();        
    }
}
