using KPO_HW1_Popov_2310.Animals;

namespace KPO_HW1_Popov_2310;

public class VetClinic
{
    public bool CheckAnimalsHealth(Animal animal)
    {
        return animal.Health > 5;
    }
}