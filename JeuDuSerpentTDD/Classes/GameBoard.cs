using System.Numerics;
using System.Runtime.CompilerServices;

namespace JeuDuSerpentTDD.Classes
{
    internal class GameBoard
    {
        public int MapLength { get; }
        public List<Player> Players { get; }
        public bool IsEnded { get; internal set; }

        public GameBoard( List<Player> players)
        {
            this.Players = players;
            this.MapLength = 50;
            this.IsEnded = false;
        }

        public Player StartGame()
        {
            Console.WriteLine("Début de la partie");
            while (!IsEnded)
                foreach (Player player in Players)
                {
                    Console.WriteLine($"{player.Name} est sur la case {player.Position}");
                    player.Roll();
                    if (IsWinner(player)) break;
                    
                }
            return FindWinner();
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