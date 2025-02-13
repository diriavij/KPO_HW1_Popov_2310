using KPO_HW1_Popov_2310.Animals;
using KPO_HW1_Popov_2310;

namespace KPO_HW1_Popov_2310_Tests
{
    public class VetClinicTests
    {
        [Fact]
        public void CheckHealth_AnimalIsHealthy_ReturnsTrue()
        {
            var healthyAnimal = new Monkey("Monkey", 4, 8, 6);
            var clinic = new VetClinic();

            var result = clinic.CheckAnimalsHealth(healthyAnimal);

            Assert.True(result);
        }

        [Fact]
        public void CheckHealth_AnimalIsUnhealthy_ReturnsFalse()
        {
            var unhealthyAnimal = new Rabbit("Rabbit", 5, 7,3);
            var clinic = new VetClinic();

            var result = clinic.CheckAnimalsHealth(unhealthyAnimal);

            Assert.False(result);
        }

        [Fact]
        public void CheckHealth_PredatorIsHealthy_ReturnsTrue()
        {
            var healthyTiger = new Tiger("Tiger", true, 9, 9);
            var clinic = new VetClinic();

            var result = clinic.CheckAnimalsHealth(healthyTiger);

            Assert.True(result);
        }

        [Fact]
        public void CheckHealth_PredatorIsUnhealthy_ReturnsFalse()
        {
            var unhealthyTiger = new Tiger("Tiger", true, 4, 4);
            var clinic = new VetClinic();

            var result = clinic.CheckAnimalsHealth(unhealthyTiger);

            Assert.False(result);
        }

        [Fact]
        public void CheckHealth_HerbivoreIsHealthy_ReturnsTrue()
        {
            var healthyRabbit = new Rabbit("Rabbit", 6, 6, 6);
            var clinic = new VetClinic();

            var result = clinic.CheckAnimalsHealth(healthyRabbit);

            Assert.True(result);
        }
    }
}