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
            player.MaxPosition = 50;
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
            player.Position = player.MaxPosition;
            player.Roll();
            Assert.AreEqual(25, player.Position);
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(30)]
        [DataRow(40)]
        public void UsePlayerRollFunction_ShouldByReRollIfIsOnMultipleOfTen(int position)
        {
            player.Position = position - 1;
            player.handleMove(1);
            Assert.IsTrue(player.Position > position);
        }


    }
}