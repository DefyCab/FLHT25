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
    }

    class Car
    {
        public string model = "Volvo";
        public int speed = 120;
        public void fullThrottle(TextBox textBox, string test)
        {
            textBox.Text = test;
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
}

