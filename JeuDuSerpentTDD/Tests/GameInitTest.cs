using JeuDuSerpentTDD.Classes;
using System.Diagnostics;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class GameInitTest
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(13)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(27)]
        [DataRow(30)]
        [DataRow(154)]
        public void UseAskPlayerCountFunction_SouldByReturnTheNumber(int numberOfPlayer)
        {
            var input = new StringReader($"{numberOfPlayer}");
            Console.SetIn(input);
            Assert.AreEqual(numberOfPlayer, GameInit.askPlayerCount());
        }

        [TestMethod]
        [DataRow("John")]
        [DataRow("Doe")]
        [DataRow("Foo")]
        [DataRow("Test")]
        public void UseAskPlayerNameFunction_SouldByReturnTheName(string name)
        {
            var input = new StringReader(name);
            Console.SetIn(input);
            Assert.AreEqual(name, GameInit.askPlayerName(1));
        }

        [TestMethod]
        [DataRow("2\nJohn\nDoe")]
        [DataRow("3\nJohn\nDoe\nFoo")]
        [DataRow("5\nJohn\nDoe\nFoo\nTest\nBar")]
        [DataRow("10\nJohn\nDoe\nJohn\nPog\nFoo\nTest\nBar\nJimmy\nPaul\nKevin")]
        public void UseGetPlayers_SouldByReturnTheTwicePlayer(string inputConsole)
        {
            var input = new StringReader(inputConsole);
            int count = int.Parse(inputConsole.Split("\n")[0]);
            Console.SetIn(input);
            List<Player> players = GameInit.getPlayers();
            Assert.AreEqual(count, players.Count);
        }
    }
}
