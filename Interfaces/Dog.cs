using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Dog : IDogWalker
    {
        public void DogBarking()
        {
            Console.WriteLine("Bark Bark");
        }
        public void WalkToTheCity()
        {
            Console.WriteLine("Walk to the city");
        }

        public void WalkToTheFoodBowl()
        {
            Console.WriteLine("Walk to the FoodBowl");
        }

        public void WalkToThePark()
        {
            Console.WriteLine("Walk to the Park");
        }
    }
}
