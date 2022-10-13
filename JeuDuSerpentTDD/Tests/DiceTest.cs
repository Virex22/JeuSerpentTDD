using JeuDuSerpentTDD.Classes;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void UseDiceRollStaticFunction_ShouldByNotReturnNull()
        {
            Assert.IsNotNull(Dice.Roll());
        }
        [TestMethod]
        public void UseDiceRollStaticFunction_ShouldByReturnANumberGreaterThanZeroAndLeastThanSeven()
        {
            for (int i = 0; i < 100; i++)
            {
                int value = Dice.Roll();
                Assert.IsTrue(value > 0 && value < 7);
            }
        }
    }
}