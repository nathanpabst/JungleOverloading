using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading.Employees
{
    class Employee
    {
        //properties
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private List<string> Restaurants { get; } = new List<string> { "Texas Tom's", "Pizza Palace", "Midieval Times", "The Dumpster" };
        private Random rando = new Random();

        //Constructor with two parameters
        public Employee(string first, string last)
        {
            FirstName = first;
            LastName = last;

        }
        //Methods
        public void Eat()
        {
            var restaurant = Restaurants[rando.Next(0, Restaurants.Count)];
            Console.WriteLine($"{FirstName} is eating at {restaurant}");
        }

        public void Eat(string food)
        {

        }

        public void Eat(List<Employee> companions)
        {

        }

        public void Eat(string food, List<Employee> companions)
        {

        }
    }
}
