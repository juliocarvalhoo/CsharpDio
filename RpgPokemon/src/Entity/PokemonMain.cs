namespace RpgPokemon.src.Entity         //colocar o nome da pasta tbm//
{
    public class PokemonMain
    {
        public string Name {get;set;}
        public string TypeOne {get; set;}
        public string TypeTwo {get; set;}
        public int Level {get; set;}
        public string? Nature {get; set;}

        public PokemonMain(string name, string typeOne, string typeTwo, int level, string nature)
        {
            this.Name = name;
            this.TypeOne = typeOne;
            this.TypeTwo = typeTwo;
            this.Nature = nature;
            
        }

        public override string ToString()
        {
            return this.Name;
        }

        public virtual string Attack(int posicao)
        {
        
            if( posicao >= 1 && posicao <= 4)
            {
                    switch(posicao)
                    {
                        case 1:
                        {
                            return this.Name + " " + "Atacou com LEECH SEED";
                        }
                        case 2:
                        {
                            return this.Name + " " + "Atacou com SOLAR BEEN";
                        }
                        case 3:
                        {
                            return this.Name + " " + "Atacou com VINES";
                        }
                        case 4:
                        {
                            return this.Name + " " + "Atacou com PETAL DANCE";
                        }
                        default:
                        {
                            return this.Name + " " + "Errou o attack";
                        }
                    }
            }
                
            else
            {
               return this.Name + "Errou o attack";

            }
                
        }

        




    }
}