using JeuDuSerpentTDD.Classes;

namespace JeuDuSerpentTDD.Tests
{
    [TestClass]
    public class GameBoardTest
    {
        private GameBoard GameBoard;

        public GameBoardTest()
        {
            List<Player> players = new List<Player>(new Player[]
            {
                new Player("John Doe"),
                new Player("Joe Biden")
            }) ;
            GameBoard = new GameBoard(players);
        }

        [TestMethod]
        public void UseGameBoardConstructor_ShouldByReturnAGameBoard()
        {
            Assert.IsNotNull(GameBoard);
        }

        [TestMethod]
        public void UseGameBoardConstructor_ShouldByHaveIsEndedToFalseAndTwoPlayer()
        {
            Assert.IsFalse(GameBoard.IsEnded);
            Assert.AreEqual(2, GameBoard.Players.Count);
        }

        [TestMethod]
        public void UseFindWinner_ShouldByThrowError()
        {
            GameBoard gameboard = new GameBoard(new List<Player>(
                new Player[] {
                    new Player("John Doe"),
                    new Player("Joe Biden") 
                }));
            Assert.ThrowsException<Exception>(() => gameboard.FindWinner());
        }

        [TestMethod]
        public void UseFindWinner_ShouldByReturnTheWinner()
        {
            GameBoard gameboard = new GameBoard(new List<Player>(
                new Player[] {
                    new Player("John Doe"),
                    new Player("Joe Biden")
                }));
            gameboard.Players[0].Position = 50;
            Assert.AreEqual(gameboard.Players[0], gameboard.FindWinner());
        }

    }
}