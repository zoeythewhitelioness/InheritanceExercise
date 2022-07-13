using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()

        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 7;

        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public bool Habitat { get; set; }
        public bool CanGrowTall { get; set; }
    }
}
