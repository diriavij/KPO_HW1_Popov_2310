using KPO_HW1_Popov_2310.Animals;

namespace KPO_HW1_Popov_2310;

public class VetClinic
{
    /// <summary>
    /// Checks if the animal is healthy enough to be added to the zoo.
    /// </summary>
    /// <param name="animal"></param>
    /// <returns></returns>
    public bool CheckAnimalsHealth(Animal animal)
    {
        return animal.Health > 5;
    }
}