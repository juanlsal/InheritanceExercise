using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            var peacock = new Bird () { BuildsNest = true, CanFly = true, CanSing = true, Name = "Peacock" };
            var snake = new Reptile () { HasTail = true, Movement = "slithers", Legs = 0, Name = "Snake" };

            peacock.Phrase();
            Console.WriteLine();
            snake.Phrase();

        }
    }
}
