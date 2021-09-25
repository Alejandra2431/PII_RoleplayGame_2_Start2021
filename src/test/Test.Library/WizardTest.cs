using NUnit.Framework;

namespace Test.Library
{
    public class WizardTests
    {

        [Test]
        public void WizardTestReceiveAttack()
        {
            Wizard wizard = new Wizard("Test0");
            wizard.ReceiveAttack(20);
            Assert.AreEqual(80, wizard.health);
        }

        [Test]
        public void WizardTestCure()
        {
            Wizard wizard = new Wizard("Test1");
            wizard.Cure();
            Assert.AreEqual(100, wizard.health);
        }

        [Test]
        public void WizardTestSpecialObjects()
        {
            Wizard wizard = new Wizard("Test2");
            wizard.Staff = new Staff();
            wizard.SpellsBook = new SpellsBook();

            Assert.NotNull(wizard.SpellsBook);
            Assert.NotNull(wizard.Staff);
        }
    }


}