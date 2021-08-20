using System;
using dotnet.src.Entities; //ctrl + .(atalho para referenciar o namespace)

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight"); // aqui faz o instanciamento do objeto
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack()); // ToString transforma esse objeto em uma string para melhor entendimento 
            
            Console.WriteLine(wizard);
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(wizard.Attack(9));

            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack(2));

        }
    }
}
