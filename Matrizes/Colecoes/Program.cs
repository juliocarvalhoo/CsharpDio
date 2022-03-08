using MatrizTridimensional.Helper;
using static System.Console;
Main();

static void Main()
{
    Demo2();
          
}


static void Demo1()
{
    int[,] ArrayInteiros = new int [3,4] {{2,4,6,8},{3,6,9,12},{4,8,12,16}};

    //int[,] ArrayInteiros = {{2,4,6,8},{3,6,9,12},{4,8,12,16}};

    for (int i = 0; i < ArrayInteiros.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayInteiros.GetLength(1); j++)
        {
            WriteLine(ArrayInteiros[i,j]);
            
        }
        
    }

}

static void Demo2()
{
    OperacoesArray op = new OperacoesArray();

    int[] arrayPares = new int[5]{6,10,2,8,4};

    WriteLine("Array Original:");
    op.ImprimirArray(arrayPares);

    WriteLine("Array ordenado:");
    op.OrdenarBubbleSorte(ref arrayPares); //ordenou
    op.ImprimirArray(arrayPares);

    bool VerdadeiroFalso = Array.Exists(arrayPares, inteiro => inteiro >= 7);
    WriteLine(VerdadeiroFalso);

}

