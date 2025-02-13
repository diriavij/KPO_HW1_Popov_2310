namespace KPO_HW1_Popov_2310.Animals;

public class Rabbit : Herbo
{
    public override void Speak()
    {
        Console.WriteLine("Chew-chew!");
    }

    public Rabbit(string name, int kindness, int food, int health) : base(name, kindness, food, health) { }
}