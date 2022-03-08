public class PokemonFire
{
    public string[] arrayFire {get;set;} 

    public PokemonFire()             //cto
    
    {
        this.arrayFire = new string[]
        {
            "Charmander",
            "Magmar",
            "Chinchar",
            "Moltres",   
        };
    
    }
    public PokemonFire (string[] arraydois)
    {
        this.arrayFire = arraydois;
                
    }



    public override string ToString() // To string Converte para string
    {
        
        foreach (var i in arrayFire)
        {
            System.Console.WriteLine(i);
            
        }
        return null;
    }

   
}


