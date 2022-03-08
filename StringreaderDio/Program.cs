using System.Text;
using static System.Console;

var sb = new StringBuilder();
sb.AppendLine("First Line");
sb.AppendLine("Second Line");
sb.AppendLine("third Line");
sb.AppendLine("End");

using var sr = new  StringReader(sb.ToString());
// var buffer = new char[10];
// var tamanho = 0;
// do
// {
//     tamanho = sr.Read(buffer);
//     Write($"{string.Join("",buffer)}");
// } while(tamanho >= buffer.Length);

do
{
    WriteLine(sr.ReadLine());  //Caractere por Caractere
}while(sr.Peek() >= 0);

WriteLine("Pressione [ENTER] para continuar....");
Console.ReadKey();

