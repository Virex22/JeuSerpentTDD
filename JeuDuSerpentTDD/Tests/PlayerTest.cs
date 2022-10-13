using JeuDuSerpentTDD.Classes;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class PlayerTest
    {
        private Player player;

        public PlayerTest()
        {
            player = new Player("John Doe");
        }

        [TestMethod]
        public void UsePlayerConstructor_ShouldHaveANameAndPosition()
        {
            Assert.IsNotNull(player.Name);
            Assert.IsNotNull(player.Position);
        }

        [TestMethod]
        public void UsePlayerConstructor_ShouldByReturnAPlayerWithANameAndPosition() {
            Assert.AreEqual("John Doe", player.Name);
            Assert.AreEqual(0, player.Position);
        }

        [TestMethod]
        public void UsePlayerRollFunction_ShouldByChangePositionAndReturnTheDifference()
        {
            int initial = player.Position;
            int difference = player.Roll();
            Assert.AreEqual(initial + difference, player.Position);
        }

        [TestMethod]
        public void CreatePlayerInstance_ShouldByThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => this.player = new Player(""));
        }
        
        [TestMethod]
        public void UsePlayerRollFunction_ShouldByChangePositionTo25IfGoTo50()
        {
            player.Position = 50;
            player.Roll();
            Assert.AreEqual(25, player.Position);
        }
    }
}