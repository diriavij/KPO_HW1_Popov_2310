namespace KPO_HW1_Popov_2310.Animals;

public class Monkey : Herbo
{
    public override void Speak()
    {
        Console.WriteLine("Ooh-ooh, ah-ah!");
    }
    
    public Monkey(string name, int kindness, int food, int health) : base(name, kindness, food, health) { }

}