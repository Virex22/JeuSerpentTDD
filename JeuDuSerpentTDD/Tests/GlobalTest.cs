using JeuDuSerpentTDD.Classes;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class GlobalTest
    {
        [TestMethod]
        [DataRow("2\nJohn\nDoe")]
        [DataRow("3\nJohn\nDoe\nFoo")]
        [DataRow("5\nJohn\nDoe\nFoo\nTest\nBar")]
        public void PlayToTheGame_ShouldBeReturnTheWinner(string arguments)
        {
            var input = new StringReader(arguments);
            Console.SetIn(input);
            
            List<Player> players = GameInit.getPlayers();
            
            GameBoard gameBoard = new GameBoard(players);
            
            Player winner = gameBoard.StartGame();
            
            Assert.IsNotNull(winner);
            Assert.IsTrue(players.Contains(winner));
        }
    }
}