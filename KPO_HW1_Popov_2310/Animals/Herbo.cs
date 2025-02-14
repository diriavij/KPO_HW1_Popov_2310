namespace KPO_HW1_Popov_2310.Animals;

/// <summary>
/// Abstract class that represents a herbo animal.
/// </summary>
public abstract class Herbo : Animal
{
    public int Kindness { get; set; }

    /// <summary>
    /// Checks if the animal's kind enough to interact with visitors;
    /// </summary>
    /// <returns></returns>
    public bool CanInteractWithVisitors()
    {
        return Kindness > 5;
    }

    public Herbo(string name, int kindness, int food, int health)
    {
        Name = name;
        Kindness = kindness;
        Food = food;
        Health = health;
    }
}