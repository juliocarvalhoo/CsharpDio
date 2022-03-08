namespace RpgProject.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
                                                  
        }

        

        public override string Attack()                     // NA PRINCIPAL USAMOS VIRTUAL
        {
            return this.Name + " " + ("Lançou Magia");
        }

        public string Attack(int bonus)                     // NA PRINCIPAL USAMOS VIRTUAL
        {
            if (bonus > 6)
            {
                return this.Name + " " + ("Lançou uma Magia Super Efetiva de bonus: ") + bonus;
            }
            else 
            {
                return this.Name + " " + ("Lançou uma Magia fraca de: ") + bonus;
            }
        }

    }
}