namespace KPO_HW1_Popov_2310.Animals;

public abstract class Animal : IAlive
{
    public string Name { get; set; }
    public int Food { get; set; }
    public int Health { get; set; }

    public abstract void Speak();
}