using KPO_HW1_Popov_2310.Inventory;
using KPO_HW1_Popov_2310.Animals;
using Microsoft.Extensions.DependencyInjection;

namespace KPO_HW1_Popov_2310
{
    public static class Program
    {
        public static void Main()
        {
            var services = new ServiceCollection();
            DependencyInjection.Configure(services);
            var serviceProvider = services.BuildServiceProvider();

            var zoo = serviceProvider.GetRequiredService<Zoo>();

            var tiger = new Tiger("Tiger Robert", true, 10, 7);
            var monkey = new Monkey("Monkey Roxanne", 7, 3, 4);
            var rabbit = new Rabbit("Rabbit John", 4, 2, 8);

            zoo.AddAnimal(tiger);
            zoo.AddAnimal(monkey);
            zoo.AddAnimal(rabbit);

            zoo.AddInventory(new Table(1));
            zoo.AddInventory(new Computer(2));

            zoo.ShowAnimals();
            zoo.ShowInventory();
            zoo.ShowInteractiveAnimals();
            Console.WriteLine($"Total food consumption: {zoo.TotalFoodConsumption()} kg");
            Console.WriteLine($"There are {zoo.GetAnimalsCount()} animals in the zoo");
            Console.WriteLine($"There are {zoo.GetInventoryCount()} inventory items in the zoo");
        }
    }
}
