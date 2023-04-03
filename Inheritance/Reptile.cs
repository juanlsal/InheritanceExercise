using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {
            BreathesAir = true;
            Legs = 4;
            HasTail = true;
            CanSwim = false;
        }

        public bool isColdBlooded { get; set; } = true;
        public string Movement { get; set; } 
        public string MovementType { get; set; }
        public int MyProperty { get; set; }


        public void Phrase()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Can swim: {CanSwim}");
            Console.WriteLine($"Is cold blooded: {isColdBlooded}");
            Console.WriteLine($"Movement: {Movement}");

        }
    }
}
