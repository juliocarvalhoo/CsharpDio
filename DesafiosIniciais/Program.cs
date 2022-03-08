using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            while(numero != 0)
            {
                if(numero % 2 == 0)
                {
                    int resposta = numero + numero + 2 + numero + 4 + numero + 6 + numero +8;
                    Console.WriteLine(resposta);
                    numero = int.Parse(Console.ReadLine());
                }

                else
                {
                    numero = numero + 1;
                    int resposta = numero + numero + 2 + numero +4 + numero + 6 + numero +8;
                    Console.WriteLine(resposta);
                    numero = int.Parse(Console.ReadLine());

                }


            }

        
        }
        
    }
}


























/*
static void Main(string[] args)
 {

    int mes = int.Parse(Console.ReadLine());
    
    switch (mes) 
    {
        case 1:
            Console.WriteLine("January");
            break;
        case 2:
            Console.WriteLine("February");
            break;
        case 3:
            Console.WriteLine("March");
            break;
        case 4:
            Console.WriteLine("April");
            break;
        case 5:
            Console.WriteLine("May");
            break;
        case 6:
            Console.WriteLine("June");
            break;
        case 7:
            Console.WriteLine("July");
            break;
        case 8:
            Console.WriteLine("August");
            break;
        case 9:
            Console.WriteLine("September");
            break;
        case 10:
            Console.WriteLine("October");
            break;
        case 11:
            Console.WriteLine("November");
            break;
        case 12:    
            Console.WriteLine("December");
            break;
            
        default:
            Console.WriteLine("Digite um número válido de 1 a 12");
            break;
    }
}*/
