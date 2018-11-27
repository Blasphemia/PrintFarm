using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Building
    {
        public string Name { get; set; }
        public double SquareOfBuilding { get; set; }
        public double CountOfAnimals { get; set; }
        public List<Animal> AnimalsInside { get; set; }
    }
}
