using KPO_HW1_Popov_2310.Animals;
using KPO_HW1_Popov_2310.Inventory;

namespace KPO_HW1_Popov_2310;

/// <summary>
/// Class that represents zoo. It keeps animals and inventory items.
/// </summary>
public class Zoo
{
    private List<IAlive> _animals = new List<IAlive>();
    private List<IInventory> _inventory = new List<IInventory>();
    private VetClinic _clinic;

    public Zoo(VetClinic clinic)
    {
        _clinic = clinic;
    }

    /// <summary>
    /// Method that adds animal to the zoo if it is healthy enough.
    /// </summary>
    /// <param name="animal"></param>
    public void AddAnimal(Animal animal)
    {
        if (_clinic.CheckAnimalsHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"Animal added to the zoo: {animal.Name}");
        }
        else
        {
            Console.WriteLine($"Animal {animal.Name} is not healthy enough!");
        }
    }

    /// <summary>
    /// Method that adds inventory item to the zoo.
    /// </summary>
    /// <param name="inventory"></param>
    public void AddInventory(IInventory inventory)
    {
        _inventory.Add(inventory);
    }

    /// <summary>
    /// Method that prints all animals of the zoo to the console.
    /// </summary>
    public void ShowAnimals()
    {
        foreach (var animal in _animals.OfType<Animal>())
        {
            Console.WriteLine($"Animal: {animal.Name}, Food consumption: {animal.Food}");
        }
    }

    /// <summary>
    /// Method that prints all inventory items of the zoo to the console.
    /// </summary>
    public void ShowInventory()
    {
        foreach (var inventory in _inventory)
        {
            Console.WriteLine($"Inventory number: {inventory.Number} is added to the zoo");
        }
    }

    /// <summary>
    /// Methods that prints only interactive animals of the zoo to the console.
    /// </summary>
    public void ShowInteractiveAnimals()
    {
        foreach (var animal in _animals.OfType<Herbo>())
        {
            if (animal.CanInteractWithVisitors())
            {
                Console.WriteLine($"Interactive animal: {animal.Name}");
            }
        }
    }

    /// <summary>
    /// Returns the total food consumption of all animals in the zoo.
    /// </summary>
    /// <returns></returns>
    public int TotalFoodConsumption()
    {
        return _animals.Sum(animal => animal.Food);
    }

    /// <summary>
    /// Returns the quantity of inventory items.
    /// </summary>
    /// <returns></returns>
    public int GetInventoryCount()
    {
        return _inventory.Count;
    }

    /// <summary>
    /// Returns the quantity of animals in the zoo.
    /// </summary>
    /// <returns></returns>
    public int GetAnimalsCount()
    {
        return _animals.Count;
    }
}