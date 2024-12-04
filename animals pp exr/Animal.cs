using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals_pp_exr
{
    internal class Animal
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }
        public int Legs { get; set; }
        public Animal(string name, string animaltype, int age, bool isvaccinated, int legs)
        {
            this.Name = name;
            this.AnimalType = animaltype;
            this.Age = age;
            this.IsVaccinated = isvaccinated;
            this.Legs = legs;
        }
    }
}
