namespace KPO_HW1_Popov_2310.Inventory;

/// <summary>
/// Abstract class that represents things that can be added to the zoo's inventory.
/// </summary>
public abstract class Thing : IInventory
{
    public string Name { get; set; }
    public int Number { get; set; }
}