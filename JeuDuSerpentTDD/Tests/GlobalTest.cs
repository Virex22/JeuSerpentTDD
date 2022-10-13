using JeuDuSerpentTDD.Classes;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class GlobalTest
    {
        [TestMethod]
        public void PlayToTheGame_ShouldBeReturnTheWinner()
        {
            var input = new StringReader("2\nJohn\nDoe");
            Console.SetIn(input);
            List<Player> players = GameInit.getPlayers();
            GameBoard gameBoard = new GameBoard(players);
            Player winner = gameBoard.StartGame();
            Assert.IsNotNull(winner);
            Assert.IsTrue(players.Contains(winner));
        }
    }
}