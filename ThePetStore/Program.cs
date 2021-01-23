using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            var babyTurtle = new Turtle("Simon");
            Turtle turtle1 = new Turtle("Mertle", 72);
            Console.WriteLine(turtle1.Description);
            turtle1.Eat("lettuce");
            turtle1.Eat("lettuce");
            turtle1.Eat();
            turtle1.ShowTime("bar-mitzvah");
            turtle1.ShowTime("birthday");
            babyTurtle.ShowTime("birthday");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
        }
    }
}
