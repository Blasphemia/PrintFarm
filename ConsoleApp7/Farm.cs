using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Farm
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public List<GardenBed> GardenBeds { get; set; }
        public List<Building> Buildings { get; set; }



        public void FarmCreation()
        {
            Product egg = new Product { Name = "Egg", MassOfProduct = 60 };
            Product milk = new Product { Name = "Milk", MassOfProduct = 1000 };
            Product meat = new Product { Name = "Meat", MassOfProduct = 1000 };
            Product wool = new Product { Name = "Wool", MassOfProduct = 1000 };

            Animal hen = new Animal { Name = "Hen", NameOfProduct = egg };
            Animal cow = new Animal { Name = "Cow", NameOfProduct = milk };
            Animal rabbit = new Animal { Name = "Rabbit", NameOfProduct = meat };
            Animal sheep = new Animal { Name = "Sheep", NameOfProduct = wool };

            Building barn = new Building { Name = "Barn", SquareOfBuilding = 100, CountOfAnimals = 5, AnimalsInside = new List<Animal>() };

            barn.AnimalsInside.Add(hen);
            barn.AnimalsInside.Add(rabbit);

            Building paddock = new Building { Name = "Paddock", SquareOfBuilding = 200, CountOfAnimals = 6, AnimalsInside = new List<Animal>() };

            paddock.AnimalsInside.Add(cow);
            paddock.AnimalsInside.Add(cow);
            paddock.AnimalsInside.Add(sheep);

            Plant pumpkin = new Plant { Name = "Pumpkin", SeasonGathering = 2, SeasonLanding = 0, SquareOnGardenBed = 30 };
            Plant beet = new Plant { Name = "Beet", SeasonGathering = 0, SeasonLanding = 2, SquareOnGardenBed = 20 };
            Plant potato = new Plant { Name = "Potato", SeasonGathering = 2, SeasonLanding = 0, SquareOnGardenBed = 30 };
            Plant onion = new Plant { Name = "Onion", SeasonGathering = 0, SeasonLanding = 3, SquareOnGardenBed = 10 };
            Plant cucumber = new Plant { Name = "Cucumber", SeasonGathering = 1, SeasonLanding = 0, SquareOnGardenBed = 20 };
            Plant carrot = new Plant { Name = "Carrot", SeasonGathering = 2, SeasonLanding = 1, SquareOnGardenBed = 20 };

            GardenBed firstGardenBed = new GardenBed { Square = 60, Plants = new List<Plant>() };

            firstGardenBed.Plants.Add(pumpkin);
            firstGardenBed.Plants.Add(carrot);

            GardenBed secondGardenBed = new GardenBed { Square = 50, Plants = new List<Plant>() };

            secondGardenBed.Plants.Add(beet);
            secondGardenBed.Plants.Add(beet);
            secondGardenBed.Plants.Add(onion);

            GardenBed thirdGardenBed = new GardenBed { Square = 40, Plants = new List<Plant>() };
            thirdGardenBed.Plants.Add(potato);


            Farm farm = new Farm { Name = "Huyarm", Square = 10000, Buildings = new List<Building>(), GardenBeds = new List<GardenBed>() };


            farm.Buildings.Add(barn);
            farm.Buildings.Add(paddock);

            farm.GardenBeds.Add(firstGardenBed);
            farm.GardenBeds.Add(secondGardenBed);
            farm.GardenBeds.Add(thirdGardenBed);

            Console.WriteLine($"Farm name - {farm.Name}, " +
                   $"square = {farm.Square.ToString()}, gardenbeds = {farm.GardenBeds.Count} buildings = {farm.Buildings.Count}");

            Console.WriteLine($"Gardenbed report: we have {farm.GardenBeds.Count} gardenbeds. First gardenbed: Square - {firstGardenBed.Square.ToString()}, \n Plants:");
            foreach (var item in firstGardenBed.Plants)
            {
                Console.Write($" Name: { item.Name}, square on the gardenbed { item.SquareOnGardenBed}, percent of total gardenbed area {Math.Round(((item.SquareOnGardenBed / firstGardenBed.Square) * 100), 2)}  \n");

            }
            Console.WriteLine("\n");
            Console.WriteLine($"Second gardenbed: Square - {secondGardenBed.Square.ToString()}, \n Plants: ");
            foreach (var item in secondGardenBed.Plants)
            {
                Console.Write($" Name: { item.Name}, square on the gardenbed { item.SquareOnGardenBed}, percent of total gardenbed area {Math.Round(((item.SquareOnGardenBed / firstGardenBed.Square) * 100), 2)} \n");

            }
            Console.WriteLine("\n");
            Console.WriteLine($"third gardenbed: Square - {thirdGardenBed.Square.ToString()}, \n Plants: ");
            foreach (var item in thirdGardenBed.Plants)
            {
                Console.Write($" Name: { item.Name}, square on the gardenbed { item.SquareOnGardenBed}, percent of total gardenbed area {Math.Round(((item.SquareOnGardenBed / firstGardenBed.Square) * 100), 2)} \n");

            }


            Console.WriteLine("\n");

            Console.WriteLine($"Buildings report: we have {farm.Buildings.Count} buildings. Barn: Square - {barn.SquareOfBuilding.ToString()}, maximum capacity: {barn.CountOfAnimals} animals. \n Animals:");
            foreach (var item in barn.AnimalsInside)
            {
                Console.Write($" Name: { item.Name}\n");

            }
            Console.WriteLine($"percent of total barn area {(barn.AnimalsInside.Count / barn.CountOfAnimals) * 100} \n \n Paddock: Square - {paddock.SquareOfBuilding.ToString()}, maximum capacity: {paddock.CountOfAnimals} animals. \n Animals:");
            foreach (var item in paddock.AnimalsInside)
            {
                Console.Write($" Name: { item.Name}\n");

            }
            Console.WriteLine($"percent of total paddock area {(paddock.AnimalsInside.Count / paddock.CountOfAnimals) * 100}");

        }



    }
}
