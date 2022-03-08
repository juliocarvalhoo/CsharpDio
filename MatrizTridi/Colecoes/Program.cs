using static System.Console;
Main();

static void Main()
{

    int[,,] ArrayTri = {{{0,0,0}, {0,0,0},{0,0,0}}};

    int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },{ { 7, 8, 9 }, { 10, 11, 12 } } };
    
    foreach (var item in ArrayTri)
    {
        WriteLine(item);
        
    }



}