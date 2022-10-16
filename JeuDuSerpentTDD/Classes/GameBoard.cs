using System.Numerics;
using System.Runtime.CompilerServices;

namespace JeuDuSerpentTDD.Classes
{
    internal class GameBoard
    {
        public int MapLength { get; internal set; }
        public List<Player> Players { get; }
        public bool IsEnded { get; internal set; }
        public int Turn { get; internal set; }

        public GameBoard(List<Player> players, int mapLength = 50)
        {
            this.Players = players;
            this.MapLength = mapLength;
            this.IsEnded = false;
            this.Turn = 1;
        }

        public Player StartGame()
        {
            Console.WriteLine("Début de la partie");
            SetMaxPositionOfPlayers();
            while (!IsEnded)
                LaunchNextTurn();
            return FindWinner();
        }

        // public for test
        public void SetMaxPositionOfPlayers()
        {
            foreach (Player player in Players)
                player.MaxPosition = MapLength;
        }

        private void LaunchNextTurn()
        {
            Console.WriteLine($"\nTour n°{Turn++}");
            foreach (Player player in Players)
            {
                Console.WriteLine($"c'est à {player.Name} (case n°{player.Position}) de jouer");
                player.Roll();
                if (IsWinner(player)) break;
            }
        }

        public bool IsWinner(Player player)
        {
            return IsEnded = player.Position == MapLength;
        }

        public Player FindWinner()
        {
            foreach (Player player in Players)
                if (player.Position == MapLength)
                    return player;
            throw new Exception("No winner found, please verify your checking before calling this method");
        }
    }
}