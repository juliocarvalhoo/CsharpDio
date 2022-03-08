using static System.Console;
Demo2();

static void Demo1()     
{
    var origin = Path.Combine(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\DirectoryOne","test.txt");
   
    if(!File.Exists(origin))
    {
    using var WriteL = File.CreateText(origin);  //POSSO COLOCAR ENTRE CHAVES TBM
    WriteL.WriteLine("Eu sou a Linha 1");
    WriteL.WriteLine("Eu sou a Linha 2");
    WriteL.WriteLine("Eu sou a Linha 3");
    //WriteL.Flush();          //MANEIRA DE ANEXAR AS LINHAS NO ARQUIVO
    }

    var pathDirectoryTwo = Path.Combine(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\DirectoryTwo","test.txt");
    // if(!Directory.Exists(pathDirectoryTwo))         
    // {
    // Directory.CreateDirectory(pathDirectoryTwo);
    // }
    MoverArquivo(origin,pathDirectoryTwo);
    
}

static void Demo2()
{
    List<string> continentList = new List<string>{"America do sul", "América do Norte", "Europa", "Asia","Oceania"};
    foreach (var continent in continentList)
    {
        string pathCreated = Path.Combine(Environment.CurrentDirectory,"Global",continent);
        Directory.CreateDirectory(pathCreated);
    }

    Directory.CreateDirectory(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\Global\América do Norte\EUA");
    Directory.CreateDirectory(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\Global\América do Norte\Canada");
    Directory.CreateDirectory(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\Global\America do sul\HUEBR");
    Directory.CreateDirectory(@"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\Global\America do sul\Argentina");

    string pathGlobal = @"C:\Users\julio\Desktop\Estudos\C#Dio\DiretoriosDio\Global";
    
    var diretorios = Directory.GetDirectories(pathGlobal,"*",SearchOption.AllDirectories);
    foreach (var continent in diretorios)
    {
        var dirInfo = new DirectoryInfo(continent);
        Console.WriteLine($"[nome]:{dirInfo.Name}");
        Console.WriteLine($"[Raiz]:{dirInfo.Root}");
        if (dirInfo!= null)
            WriteLine($"[Pai]:{dirInfo.Parent.Name}");
        
        WriteLine("-------------------------------");
        
    }
   
    //int tamanho = pathGlobal.Length;
    // foreach (string item in print)
    // {       
    //     WriteLine(item.Substring(tamanho+1));   
    // }
    
}

static void Demo3()
{
    
}

static void MoverArquivo(string origin, string pathDirectoryTwo)
{
    File.Move(origin,pathDirectoryTwo);
}



