namespace KPO_HW1_Popov_2310.Inventory;

public abstract class Thing : IInventory
{
    public string Name { get; set; }
    public int Number { get; set; }
}