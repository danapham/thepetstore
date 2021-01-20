using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Turtle turtle1 = new Turtle("Mertle", 72);
            //turtle1.Eat("lettuce");
            //turtle1.Eat("lettuce");
            //turtle1.Eat();
            //turtle1.ShowTime("bar-mitzvah");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
        }
    }
}
