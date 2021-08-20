namespace dotnet.src.Entities
{
    public class Ninja : Hero
    {
       public Ninja(string Name, int Level, string HeroType)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
       } 
       
       public Ninja(){

       }

        public string Attack(int Bonus)
        {
            return this.Name + " O Ninja lançou várias shurikens e recebeu bonus " + Bonus;
        }

    }
}