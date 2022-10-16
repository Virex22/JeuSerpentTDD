using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuSerpentTDD.Classes
{
    internal static class GameInit
    {
        internal static List<Player> getPlayers()
        {
            int numberOfPlayer = AskPlayerCount();

            return AskAllPlayersName(numberOfPlayer);
        }

        internal static List<Player> AskAllPlayersName(int numberOfPlayer)
        {
            List<Player> players = new List<Player>();
            
            for (int i = 0; i < numberOfPlayer; i++)
                players.Add(new Player(AskPlayerName(i)));
            
            return players;
        }
        
        internal static int AskMapLength()
        {
            Console.WriteLine("Quelle taille de plateau voulez-vous ?");
            return int.Parse(Console.ReadLine());
        }

        internal static void AskPlayerCountAndNames()
        {
            int numberOfPlayer = AskPlayerCount();
                                                    
            for (int i = 0; i < numberOfPlayer; i++)
                AskPlayerName(i);
        }

        internal static int AskPlayerCount()
        {
            Console.WriteLine("Combien de joueurs ?");
            int numberOfPlayer = int.Parse(Console.ReadLine());

            if (numberOfPlayer < 2)
                throw new UnvalidNumberOfPlayerException();

            return numberOfPlayer;
        }

        internal static string AskPlayerName(int i)
        {
            Console.WriteLine($"Nom du joueur {i + 1} ?");
            return Console.ReadLine();
        }

    }

    [Serializable]
    internal class UnvalidNumberOfPlayerException : Exception
    {
        public UnvalidNumberOfPlayerException()
        {
        }

        public UnvalidNumberOfPlayerException(string? message) : base(message)
        {
        }

        public UnvalidNumberOfPlayerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UnvalidNumberOfPlayerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
