using KPO_HW1_Popov_2310.Inventory;
using KPO_HW1_Popov_2310.Animals;
using Microsoft.Extensions.DependencyInjection;

namespace KPO_HW1_Popov_2310
{
    public static class Program
    {
        public static void Main()
        {
            // Creating zoo and vet clinic instances.
            var services = new ServiceCollection();
            DependencyInjection.Configure(services);
            var serviceProvider = services.BuildServiceProvider();

            var zoo = serviceProvider.GetRequiredService<Zoo>();

            // Adding animals and inventory items to the zoo based on the
            // information provided by the user via console input.
            Console.WriteLine("Enter the number of animals:");
            int animalCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine("Select the type of animal (1 - Tiger, 2 - Monkey, 3 - Rabbit, 4 - Wolf):");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter the animal's name: ");
                string name = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Is the tiger dangerous? (true/false): ");
                        bool isDangerousTiger = bool.Parse(Console.ReadLine());
                        Console.Write("Enter the food consumption (kg): ");
                        int foodTiger = int.Parse(Console.ReadLine());
                        Console.Write("Enter the health level: ");
                        int healthTiger = int.Parse(Console.ReadLine());
                        zoo.AddAnimal(new Tiger(name, isDangerousTiger, foodTiger, healthTiger));
                        break;
                    case 2:
                        Console.Write("Enter the monkey's kindness level: ");
                        int kindnessMonkey = int.Parse(Console.ReadLine());
                        Console.Write("Enter the food consumption (kg): ");
                        int foodMonkey = int.Parse(Console.ReadLine());
                        Console.Write("Enter the health level: ");
                        int healthMonkey = int.Parse(Console.ReadLine());
                        zoo.AddAnimal(new Monkey(name, kindnessMonkey, foodMonkey, healthMonkey));
                        break;
                    case 3:
                        Console.Write("Enter the rabbit's kindness level: ");
                        int kindnessRabbit = int.Parse(Console.ReadLine());
                        Console.Write("Enter the food consumption (kg): ");
                        int foodRabbit = int.Parse(Console.ReadLine());
                        Console.Write("Enter the health level: ");
                        int healthRabbit = int.Parse(Console.ReadLine());
                        zoo.AddAnimal(new Rabbit(name, kindnessRabbit, foodRabbit, healthRabbit));
                        break;
                    case 4:
                        Console.Write("Is the wolf dangerous? (true/false): ");
                        bool isDangerousWolf = bool.Parse(Console.ReadLine());
                        Console.Write("Enter the food consumption (kg): ");
                        int foodWolf = int.Parse(Console.ReadLine());
                        Console.Write("Enter the health level: ");
                        int healthWolf = int.Parse(Console.ReadLine());
                        zoo.AddAnimal(new Wolf(name, isDangerousWolf, foodWolf, healthWolf));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        i--;
                        break;
                }
            }

            Console.WriteLine("Enter the number of inventory items:");
            int inventoryCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inventoryCount; i++)
            {
                Console.WriteLine("Select the type of inventory (1 - Table, 2 - Computer):");
                int choice = int.Parse(Console.ReadLine());
                
                Console.Write("Enter the inventory ID: ");
                int id = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        zoo.AddInventory(new Table(id));
                        break;
                    case 2:
                        zoo.AddInventory(new Computer(id));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        i--;
                        break;
                }
            }
            
            // Printing information about the zoo to the console.
            Console.WriteLine("Zoo Info:");
            zoo.ShowAnimals();
            zoo.ShowInventory();
            zoo.ShowInteractiveAnimals();
            Console.WriteLine($"Total food consumption: {zoo.TotalFoodConsumption()} kg");
            Console.WriteLine($"There are {zoo.GetAnimalsCount()} animals in the zoo");
            Console.WriteLine($"There are {zoo.GetInventoryCount()} inventory items in the zoo");
        }
    }
}