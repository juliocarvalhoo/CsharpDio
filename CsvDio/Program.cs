using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory,"Entrada","dadoscomma.csv");
using StreamReader sr = new StreamReader(path);
var cabecalho = sr.ReadLine()?.Split(",");

while(true)
{
    var registro = sr.ReadLine()?.Split(",");
    if(registro == null) break;

    for(int i = 0; i < registro.Length; i++)
    {
        WriteLine($"{cabecalho?[i]} : {registro[i]}");
    }
    WriteLine("-----------------------------");
}
WriteLine("Press [ENTER] To Continue...");
