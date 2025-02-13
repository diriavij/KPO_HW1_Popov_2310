using KPO_HW1_Popov_2310;
using KPO_HW1_Popov_2310.Animals;
using KPO_HW1_Popov_2310.Inventory;

namespace KPO_HW1_Popov_2310_Tests
{
    public class ZooTests
    {
        [Fact]
        public void AddAnimal_AnimalIsHealthy_AnimalIsAddedToZoo()
        {
            var healthyAnimal = new Monkey("Monkey", 6, 5, 8);
            var clinic = new VetClinic();
            var zoo = new Zoo(clinic);

            zoo.AddAnimal(healthyAnimal);

            var result = zoo.TotalFoodConsumption();

            Assert.Equal(5, result);
        }

        [Fact]
        public void AddAnimal_AnimalIsUnhealthy_AnimalIsNotAddedToZoo()
        {
            var unhealthyAnimal = new Rabbit("Rabbit", 8, 3, 2);
            var clinic = new VetClinic();
            var zoo = new Zoo(clinic);

            zoo.AddAnimal(unhealthyAnimal);

            var result = zoo.TotalFoodConsumption();

            Assert.Equal(0, result);
        }

        [Fact]
        public void ShowInteractiveAnimals_HerbivoresWithKindnessGreaterThan5_AreAvailableForInteraction()
        {
            var friendlyMonkey = new Monkey("Friendly Monkey", 6, 8, 3);
            var unfriendlyRabbit = new Rabbit("Unfriendly Rabbit", 4, 7, 2);
            var clinic = new VetClinic();
            var zoo = new Zoo(clinic);

            zoo.AddAnimal(friendlyMonkey);
            zoo.AddAnimal(unfriendlyRabbit);

            zoo.ShowInteractiveAnimals();
        }

        [Fact]
        public void AddInventory_ItemIsAddedToZooInventory()
        {
            var table = new Table(1);
            var zoo = new Zoo(new VetClinic());

            zoo.AddInventory(table);

            Assert.Equal(1, zoo.GetInventoryCount());
        }

        [Fact]
        public void ShowInventory_ShouldDisplayInventoryItems()
        {
            var table = new Table(1);
            var computer = new Computer(2);
            var zoo = new Zoo(new VetClinic());

            zoo.AddInventory(table);
            zoo.AddInventory(computer);

            zoo.ShowInventory();
        }
        
        [Fact]
        public void GetAnimalsCount_ReturnsCorrectCount()
        {
            var monkey = new Monkey("Monkey", 3, 5, 8);
            var rabbit = new Rabbit("Rabbit", 5, 3, 7);
            var clinic = new VetClinic();
            var zoo = new Zoo(clinic);

            zoo.AddAnimal(monkey);
            zoo.AddAnimal(rabbit);

            var result = zoo.GetAnimalsCount();

            Assert.Equal(2, result);
        }
    }
}