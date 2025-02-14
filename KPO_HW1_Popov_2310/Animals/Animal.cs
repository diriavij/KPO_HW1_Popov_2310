namespace KPO_HW1_Popov_2310.Animals;

/// <summary>
///  Abstract class that represents animal that can be added to the zoo.
/// </summary>
public abstract class Animal : IAlive
{
    public string Name { get; set; }
    public int Food { get; set; }
    public int Health { get; set; }

    public abstract void Speak();
}