using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dog()
        {
            Name = "Turtle";
            Age = 10;
        }
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
