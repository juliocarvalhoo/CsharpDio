using static System.Console;
Main();

static void Main()
{
    int[] arrayNumeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
        var numerosParesQuery =
        from num in arrayNumeros
        where num % 2 == 0
        orderby num
        select num;

    var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x =>x).ToList();

    var emptyQuery = string.Join(",",numerosParesQuery); 
    WriteLine(emptyQuery);

    foreach (var item in numerosParesMetodo)
    {
        WriteLine(item);
        
    }

    
}