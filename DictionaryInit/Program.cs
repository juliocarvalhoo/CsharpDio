using static System.Console;



//Dictionary <int, string> Farmacia  = new Dictionary <int, string>();
Dictionary <int, string> Farmacia  = new Dictionary <int, string>();

Farmacia.Add( 1, "Voltarem");
Farmacia.Add( 2, "Betaestina");
Farmacia.Add( 3, "clonazepam");
Farmacia.Add( 4, "Oneprazol");

foreach (KeyValuePair<int,string> item in Farmacia)
{
    WriteLine($"Código: {item.Key}, Produto: {item.Value}");
}

int Digestao = 4;
WriteLine(Farmacia[Digestao]);

