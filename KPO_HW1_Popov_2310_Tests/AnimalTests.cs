using KPO_HW1_Popov_2310.Animals;

namespace KPO_HW1_Popov_2310_Tests
{
    public class AnimalTests
    {
        [Fact]
        public void CheckAnimalSound_Rabbit_ReturnsTrue()
        {
            Rabbit rabbit = new Rabbit("Rabbit", 6, 6, 6);
        
            Assert.Equal("Chew-chew!", rabbit.Speak());
        }
    
        [Fact]
        public void CheckAnimalSound_Monkey_ReturnsTrue()
        {
            Monkey monkey = new Monkey("Monkey", 6, 6, 6);
        
            Assert.Equal("Ooh-ooh, ah-ah!", monkey.Speak());
        }
    
        [Fact]
        public void CheckAnimalSound_Tiger_ReturnsTrue()
        {
            Tiger tiger = new Tiger("Tiger", true, 6, 6);
        
            Assert.Equal("Roar!", tiger.Speak());
        }
    
        [Fact]
        public void CheckAnimalSound_Wolf_ReturnsTrue()
        {
            Wolf wolf = new Wolf("Wolf", true, 6, 6);
        
            Assert.Equal("Wo-o-o-f!", wolf.Speak());
        }
    }
}

