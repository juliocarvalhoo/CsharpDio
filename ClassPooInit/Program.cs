using ClassPooInit.Helper;
using ClassPooInit.Interfaces;
using ClassPooInit.Models;
using static System.Console;





Pessoa p1 = new Pessoa();
p1.Name = "João";
p1.Age = 22;

p1.Apresentar();

Retangulo r1 = new Retangulo();
r1.DefinirMedidas(10, 10 );

WriteLine("Area do apartamento de {0}: {1}",p1.Name,r1.ObterArea());

Aluno a1 = new Aluno();
a1.Name = "Alexandre";
a1.Age = 30;
a1.Score = 8.5;

Professor t1 = new Professor();
t1.Name = "Thiago";
t1.Age = 32;
t1.Wage = 1.249;

a1.Apresentar();
t1.Apresentar();

Icalculadora calc = new Calculadora();
WriteLine(calc.Somar(5,6));

FileHelper help = new FileHelper();
var caminho = @"C:\Users\julio\Desktop\Estudos\C#Dio\DirectoryEmpty";
help.Listardiretorios(caminho);
help.Listararquivos(caminho);

WriteLine("\n");


help.CreatedDirectory(Path.Combine(caminho,"pasta 3","subpasta3","subsubpasta3"));

var caminhoDelete = Path.Combine(caminho,"pasta 3");

help.DeleteDirectory(caminhoDelete,true);

var caminhoFileText = Path.Combine(caminho,"goku.txt");

help.CreatedFile(caminhoFileText,"Olá eu sou o Goku, Obrigado por abrir a Pasta, Seu mundo está a Salvo!");





