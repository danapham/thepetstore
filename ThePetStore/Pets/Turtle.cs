using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    public class Turtle
    {
        //Properties - Things are externally consumable

        //readonly property -> can only be set once and in the constructor/instantiation process
        public string Name { get; }
        //readonly property, but can only be calculated/derived
        public string Description => $"{Age} year old {Size}, {Color} turtle";

        //public property with a private setter
        public int Age { get; private set; }

        //auto-property
        public string Size { get; set; }
        public string Color { get; set; }

        //field backed property - that's what the auto-property get/sets work
        string _shellPattern = "squares";
        public string ShellPattern
        { 
            get { return _shellPattern; }
            set { _shellPattern = value;  }
        }

        //what properties really are
        //string get__ShellPattern()
        //{
        //    return "";
        //}

        //Fields - internal private things
        private bool _isHungry = true;

        //Constructor overloading - this will choose constructor based on its signature
        public Turtle(string name) : this(name,0)
        { }
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle's name is {Name} and it's age is {Age}");
        }

        //Method
        //method signature return type, name, parameters
        public void Eat()
        {
            Eat("pellets");
        }

        //Method Overloading
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle stretches their neck out and munches on the {foodType}.");
                _isHungry = !_isHungry;
            }
            else
            {
                Console.WriteLine("Shakes its head and says no thank you!");
                _isHungry = !_isHungry;
            }

        }

        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            }
            else
            {
                Console.WriteLine($"No occasion...");
            }

            if (occasion == "birthday")
            {
                Console.WriteLine($"{Name} is now {++Age} years old");
            }

            DressUp("fancy bloomer");
        }

        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing a {clothing}.");
        }
    }
}
