namespace KPO_HW1_Popov_2310.Animals;

public class Wolf : Predator
{
    public override string Speak()
    {
        return "Wo-o-o-f!";
    }
    public Wolf(string name, bool isDangerous, int food, int health) : base(name, isDangerous, food, health) { }

}