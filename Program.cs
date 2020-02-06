using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TutorialApp
{
    
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "McChungus";
            person.Age = 26;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
