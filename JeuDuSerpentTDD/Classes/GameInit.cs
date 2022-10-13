using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuSerpentTDD.Classes
{
    internal static class GameInit
    {
        internal static List<Player> getPlayers()
        {
            List<Player> players = new List<Player>();
            int numberOfPlayer = askPlayerCount();
            for (int i = 0; i < numberOfPlayer; i++)
                players.Add(new Player(askPlayerName(i)));
            return players;
        }

        internal static void askPlayerCountAndNames()
        {
            int nbPlayers = askPlayerCount();
            for (int i = 0; i < nbPlayers; i++)
                askPlayerName(i);
        }
        
        internal static int askPlayerCount()
        {
            Console.WriteLine("Combien de joueurs ?");
            return int.Parse(Console.ReadLine());
        }

        internal static string askPlayerName(int i)
        {
            Console.WriteLine($"Nom du joueur {i + 1} ?");
            return Console.ReadLine();
        }

    }
}
