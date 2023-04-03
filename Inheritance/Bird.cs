using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
            BreathesAir = true;
            Legs = 2;
            HasTail = true;
            CanSwim = true;
            HasFeathers = true;
        }

        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool CanSing { get; set; }
        public bool BuildsNest { get; set; }


        public void Phrase ()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Can Sing: {CanSing}");
            Console.WriteLine($"Builds Nest: {BuildsNest}");

        }
    }
}
