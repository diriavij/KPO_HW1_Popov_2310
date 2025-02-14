using KPO_HW1_Popov_2310.Animals;
using KPO_HW1_Popov_2310.Inventory;

namespace KPO_HW1_Popov_2310;

public class Zoo
{
    private List<IAlive> _animals = new List<IAlive>();
    private List<IInventory> _inventory = new List<IInventory>();
    private VetClinic _clinic;

    public Zoo(VetClinic clinic)
    {
        _clinic = clinic;
    }

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

    public void AddInventory(IInventory inventory)
    {
        _inventory.Add(inventory);
    }

    public void ShowAnimals()
    {
        foreach (var animal in _animals.OfType<Animal>())
        {
            Console.WriteLine($"Animal: {animal.Name}, Food consumption: {animal.Food}");
        }
    }

    public void ShowInventory()
    {
        foreach (var inventory in _inventory)
        {
            Console.WriteLine($"Inventory number: {inventory.Number} is added to the zoo");
        }
    }

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

    public int TotalFoodConsumption()
    {
        return _animals.Sum(animal => animal.Food);
    }

    public int GetInventoryCount()
    {
        return _inventory.Count;
    }

    public int GetAnimalsCount()
    {
        return _animals.Count;
    }
}