namespace KPO_HW1_Popov_2310.Animals;

public class Tiger : Predator
{
    public override void Speak()
    {
        Console.WriteLine("Roar!");
    }
    public Tiger(string name, bool isDangerous, int food, int health) : base(name, isDangerous, food, health) { }
}