using System;
using static System.Console;

string nome = "none";
string cidade = "none";
string curso = "none";
string opcaoUsuario = "none";

WriteLine("ESCOLHA UMA OPÇÂO:");
WriteLine("(A): ALTERE O NOME");
WriteLine("(B): ALTERE A CIDADE");
WriteLine("(C): ALTERE O CURSO");
WriteLine("(X): SAIR");
WriteLine();

opcaoUsuario = ReadLine();

while(opcaoUsuario.ToUpper() != "X")
{    
    switch(opcaoUsuario.ToUpper())
    {
        case "A":
        {
            WriteLine("Nome:");
            nome = ReadLine();
            break;
        }

        case "B":
        {
            WriteLine("Cidade:");
            cidade = ReadLine();
            break;
        }
        case "C":
        {
            WriteLine("Curso:");
            curso = ReadLine();
            break;
        }
        
        default:
            throw new ArgumentOutOfRangeException("COMANDO INVÁLIDO");

    }
Clear();
WriteLine("ESCOLHA UMA OPÇÂO:");
WriteLine("(A): ALTERE O NOME");
WriteLine("(B): ALTERE A CIDADE");
WriteLine("(C): ALTERE O CURSO");
WriteLine("(X): SAIR");
WriteLine();

opcaoUsuario = ReadLine();

}

WriteLine("NOME:.......{0}",nome);
WriteLine("CIDADE:.....{0}",cidade);
WriteLine("CURSO:......{0}",curso);

