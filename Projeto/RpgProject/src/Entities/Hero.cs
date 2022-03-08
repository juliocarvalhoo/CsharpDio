namespace RpgProject.src.Entities
{
    public abstract class Hero
    {
        public string Name {get;set;}           //PROPRIEDADE
        public int Level {get;set;}
        public string HeroType {get;set;}
        
        public Hero(string name, int level, string heroType )  //LARANJA PARAMÊTRO
        {
            this.Name = name;                                   //THIS PARA MOSTRA QUE È DA MSM CLASSE
            this.Level = level;
            this.HeroType = heroType;                                          
        }

        public override string ToString()                   //override modifico padrão de um método
        {
            return $@"
{this.Name} 
{this.Level}
{this.HeroType}"
        ;}

        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com sua espada";
        }
            
    }
}
