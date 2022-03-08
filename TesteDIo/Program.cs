using static System.Console;
Main();

static void Main()
    {
        Team p1 = new Team();
        p1.Pokemon = "Bulbasaur";
        p1.Type = "Glass";
        p1.Evolucao = "Venusaur";
        p1.Level = 17;
        WriteLine("imprimindo");
        WriteLine(p1.Pokemon);

        PokemonFire fogo = new PokemonFire();

        WriteLine(fogo); 

        string[] Water = new string[]
        {
            "Squirtle",
            "Blastoise",
            "Starmie",
            "Totodile",   
        };
    
        PokemonFire waterPokemons = new PokemonFire(Water);
        WriteLine(waterPokemons);      
    }
