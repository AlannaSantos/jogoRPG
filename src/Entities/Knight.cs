namespace dotnet.src.Entities
{
    public class Knight : Hero
    {
       public Knight(string Name, int Level, string HeroType)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
       }

       public Knight(){

       } 

       public string Attack() // virtul : filhos que herdam desta classe podem alterar este comportamento(metodo)
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}