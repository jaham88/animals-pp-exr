namespace animals_pp_exr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animalsList = new List<Animal>
            {
                new Animal("Kalle", "Dog", 5, true, 4),
                new Animal("Kissen", "Cat", 3, false, 4),
                new Animal("Skalet", "Turtle", 47, true, 4),
                new Animal("Linus", "Dog", 9, true, 4),
                new Animal("Zoro", "Cat", 13, false, 4),
                new Animal("Birdie", "Bird", 2, false, 2),
                new Animal("Pippi", "Bird", 2, false, 3),
                new Animal("Herr Nilsson", "Monkey", 5, true, 2),
                new Animal("Lilla Gubben", "Horse", 11, true, 4),
                new Animal("Svarten", "Horse", 3, false, 4),
                new Animal("Viten", "Horse", 1, true, 4)

            };

            var howManyDogs = animalsList.
                Count(d => d.AnimalType == "Dog");

            Console.WriteLine($"Det är så här många hundar i listan = {howManyDogs}");

            Console.WriteLine("\n" +
                "----------------------------------------------------------------------------------------" +
                "\n");

            var OldestAnimal = animalsList.
                OrderBy(a => a.Age).
                First();
            Console.WriteLine($"Namn: {OldestAnimal.Name}" +
                $"\nRas: {OldestAnimal.AnimalType}" +
                $"\nÅlder: {OldestAnimal.Age}" +
                $"\nÄr äldsta djuret just nu.");

            Console.WriteLine("\n" +
                "----------------------------------------------------------------------------------------" +
                "\n");

            var isVaccinated = animalsList.
                Where(v => v.IsVaccinated == true).ToList();
            foreach ( var animal in isVaccinated )
                Console.WriteLine($"vaccinerade: " +
                    $"{animal.Name} {animal.AnimalType} {animal.Age}");

            Console.WriteLine("\n" +
                "----------------------------------------------------------------------------------------" +
                "\n");

            var fourLegsOverAgeThree = animalsList.
                Where(l => l.Legs == 4 && l.Age > 3).
                ToList();
            foreach ( var animal in isVaccinated )
                Console.WriteLine($"{animal.Name} {animal.AnimalType} {animal.Age}");

            Console.WriteLine("\n" +
                "----------------------------------------------------------------------------------------" +
                "\n");

            bool isnameshadow = animalsList.Any(a => a.Name == "Shadow");
            Console.WriteLine(isnameshadow);

        }
    }
}
