using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FL
{
    class Person
    {
        public required string Name { get; set; }
        public required int Age { get; set; }

        public string returnPerson()
        {
            string person = $"Jag heter {Name} och är {Age} år gammal";

            return person;
        }

        public string returnPerson2(Person person)
        {
            string name = person.Name;
            int age = person.Age;
            return $"Jag heter {name} och är {age} år gammal"; 
        }
    }

    class Car
    {
        public string model;
        public int speed;
        public void fullThrottle(TextBox mimmi, string test)
        {
            mimmi.Text = test;
        }

    }

    public class Robot
    {
        public static string Species = "Cyborg";

        public string namn = "John";

        public void sayHello(TextBox textBox)
        {
            textBox.Text = $"Hej, jag heter {namn}, jag är en {Species}";
        }
    }

    public class Channel
    {
        public int SubCount => Subscribers.Count;

        public List<string> Subscribers = new List<string>()
        {
            "Love", "Erik"
        };
    }



}

