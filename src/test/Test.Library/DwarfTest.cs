using NUnit.Framework;

namespace Test.Library
{
    public class DwarfTest
    {

        [Test]
        public void DwarfReceiveAttack()
        {
            Dwarf dwarf = new Dwarf("Dwarf1");
            dwarf.ReceiveAttack(50);
            Assert.AreEqual(50, dwarf.health);
        }

        [Test]
        public void DwarfCure()
        {
            Dwarf dwarf = new Dwarf("Dwarf2");
            dwarf.Cure();
            Assert.AreEqual(100, dwarf.health);
        }
    }
}