using System;

namespace AnimalShelter.Solution
{

    public class Animal 
    { 
        public int Id {get; set;}
        public string Name {get; set; }
        public DateTime DateOfAdmittance {get; set; }
        public string Breed { get; set; }

        public in TypeId {get; set; }
        public Type Type {get; set; }
    }
}