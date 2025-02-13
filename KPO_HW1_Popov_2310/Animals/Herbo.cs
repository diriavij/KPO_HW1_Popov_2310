namespace KPO_HW1_Popov_2310.Animals;

public abstract class Herbo : Animal
{
    public int Kindness { get; set; }

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