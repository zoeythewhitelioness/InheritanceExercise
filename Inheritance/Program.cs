using System;

namespace Inheritance
{
   public class Program
    {
        private const bool V = true;

        static void Main(string[] args)
        {

            var myBird = new Bird();
           
             myBird.WingColor = "blue";
             myBird.CanFly = V;
            myBird.BeakLength = "3.5";
           


            var lizard = new Reptile()

            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = true,
                CanGrowTall = true
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
            }
        }
    }
}
