using System;

namespace ConsoleApp1_csharp
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }

        public Animal(int id, string species, string breed)
        {
            Id = id;
            Species = species;
            Breed = breed;
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-15} {2,-20}", Id, Species, Breed); //ID, Вид, Порода
        }
    }
}