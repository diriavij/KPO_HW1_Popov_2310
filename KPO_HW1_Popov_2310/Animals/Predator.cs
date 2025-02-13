namespace KPO_HW1_Popov_2310.Animals;

public abstract class Predator : Animal
{
    public bool IsDangerous { get; set; }

    public Predator(string name, bool isDangerous, int food, int health)
    {
        Name = name;
        IsDangerous = isDangerous;
        Food = food;
        Health = health;
    }
}