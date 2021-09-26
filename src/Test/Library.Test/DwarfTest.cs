using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class DwarfTest
    {
        [Test]
        public void ReciveDamageTest()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            int damage = 10;
            int expectedHealth = 100 - 10;
            dwarf.RecieveDamage(damage);
            Assert.AreEqual(expectedHealth, dwarf.CurrentHealth());
        }

        [Test]
        public void AttackEnemyDwarf1Test()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            Dwarf dwarf1 = new Dwarf("dwarf1");
            dwarf.AttackEnemy(dwarf1);
            int expectedHealth = 100 - 15;
            Assert.AreEqual(expectedHealth, dwarf1.CurrentHealth());
        }

        [Test]
        public void EquipItemAttackTest()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            Item itemAtaque = new Item("Knife", 15, 0);
            dwarf.EquipItem(itemAtaque);
            int expectedAttack = 15 + 15;
            int expectedArmor = 40;
            Assert.IsNotEmpty(dwarf.ReturnInventory());
            Assert.AreEqual(expectedAttack, dwarf.ReturnAttack());
            Assert.AreEqual(expectedArmor, dwarf.ReturnArmor());
        }

        [Test]
        public void UnEquipItemTest()
        {
            Dwarf dwarf = new Dwarf("dwarf1");
            Item itemAtaque = new Item("Knife", 20, 0);
            dwarf.EquipItem(itemAtaque);
            int expectedAttack = 15 + 20;
            Assert.AreEqual(expectedAttack, dwarf.ReturnAttack());

            dwarf.UnequipItem(itemAtaque);
            expectedAttack = 35 - 20;
            Assert.AreEqual(expectedAttack, dwarf.ReturnAttack());
            Assert.IsEmpty(dwarf.ReturnInventory());
        }

    }
}