using JeuDuSerpentTDD.Classes;
using System.Diagnostics;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class GameInitTest
    {
        private void WriteToConsole(string command)
        {
            var input = new StringReader(command);
            Console.SetIn(input);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(17)]
        [DataRow(27)]
        [DataRow(30)]
        public void UseAskPlayerCountFunction_SouldByReturnTheNumber(int numberOfPlayer)
        {
            WriteToConsole($"{numberOfPlayer}");
            
            Assert.AreEqual(numberOfPlayer, GameInit.AskPlayerCount());
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        public void UseAskPlayerCountFunction_SouldByThrowArgumentException(int numberOfPlayer)
        {
            WriteToConsole($"{numberOfPlayer}");
            
            Assert.ThrowsException<UnvalidNumberOfPlayerException>(() => GameInit.AskPlayerCount());
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(13)]
        [DataRow(18)]
        [DataRow(154)]
        public void UseAskMapLenght_SouldByReturnTheNumber(int mapLenght)
        {
            WriteToConsole($"{mapLenght}");
            
            Assert.AreEqual(mapLenght, GameInit.AskMapLength());
        }

        [TestMethod]
        [DataRow("John")]
        [DataRow("Doe")]
        [DataRow("Foo")]
        [DataRow("Test")]
        public void UseAskPlayerNameFunction_SouldByReturnTheName(string name)
        {
            WriteToConsole(name);
            
            Assert.AreEqual(name, GameInit.AskPlayerName(1));
        }

        [TestMethod]
        [DataRow("2\nJohn\nDoe")]
        [DataRow("3\nJohn\nDoe\nFoo")]
        [DataRow("5\nJohn\nDoe\nFoo\nTest\nBar")]
        [DataRow("10\nJohn\nDoe\nJohn\nPog\nFoo\nTest\nBar\nJimmy\nPaul\nKevin")]
        public void UseGetPlayers_SouldByReturnTheTwicePlayer(string inputConsole)
        {
            WriteToConsole(inputConsole);
            
            int count = int.Parse(inputConsole.Split("\n")[0]);
            
            List<Player> players = GameInit.getPlayers();
            
            Assert.AreEqual(count, players.Count);
        }
    }
}
