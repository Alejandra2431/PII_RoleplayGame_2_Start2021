using NUnit.Framework;


namespace RoleplayGame.Tests
{
    public class ArcherTest
    {
        /// <summary>
        /// Prueba con power mayor que el valor de la defensa
        /// </summary>
        [Test]
        public void ReceiveAttackTest1()
        {
            Archer archer = new Archer("archer");
            int power = 15;
            archer.DefenseValue = 5;
            archer.Health = 100;
            archer.ReceiveAttaAttack(power);
            int expectedHealth = 90;
            Assert.AreEqual(expectedHealth, archer.Health);
        }

        /// <summary>
        /// Prueba con power no mayor al valor de la defensa
        /// </summary>
        [Test]
        public void ReceiveAttackTest2()
        {
            Archer archer = new Archer("archer");
            int power = 15;
            archer.DefenseValue = 15;
            archer.Health = 100;
            archer.ReceiveAttaAttack(power);
            int expectedHealth = 100; 
            Assert.AreEqual(expectedHealth, archer.Health);
        }

    }
}
