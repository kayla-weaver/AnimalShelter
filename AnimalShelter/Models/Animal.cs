using System;

namespace AnimalShelter.Models
{

    public class Animal 
    { 
        public int Id {get; set;}
        public string Name {get; set; }
        public DateTime DateOfAdmittance {get; set; }
        public string Breed { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}