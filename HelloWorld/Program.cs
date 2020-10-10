using System;
using System.Collections.Generic;

namespace HelloWorld
{
    interface IExample // blueprint/structure for creating an object that will be an instance of the interface
    // dependency injection - what is the specific service or class responsible for implementing interface
    {
        public int Age { get; set; } //property of the interface
        void LearnDotNet(); // action/method of the interface
    }
    class Animal
    {
        protected string Name { get; set; } // property. make a property protected to allow access in same class and children

        public void DoSomething() // method
        {
            Name = "Dumbo"; // set
            string myName = Name; // get
        }

        protected virtual void MakesSound() // protected means only children can use this method, virtual means it can be overriden in child class
        {
            Console.WriteLine("Grrrrrrrr!");
        }
    }

    // class Dog : Animal, IExample // inherits from Animal like extends
    class Dog : IExample
    {
        public int Age { get; set; }
        private bool isMorning = false;
        private List<string> myNumbers = new List<string>() { "One", "Two", "Three" };

        public void LearnDotNet()
        {
            if(isMorning)
            {
                //
            }
            else
            {
                //
            }

            for (int i = 0; i < myNumbers.Count; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            
            foreach (var number in myNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("We are learning");
        }

        public void SetMorning()
        {
            isMorning = true;
        }

    // protected override void MakesSound() // access modifier and child must both be protected
    //     {
    //         Console.WriteLine("Wow Wow!");
    //     }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
