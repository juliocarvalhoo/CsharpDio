namespace RpgProject.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
                                                  
        }

        public override string Attack()                     // NA PRINCIPAL USAMOS VIRTUAL
        {
            return this.Name + " " + ("Atacou com seu Machado");
        }

    }
}
