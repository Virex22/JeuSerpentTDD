using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuSerpentTDD.Classes
{
    internal static class Dice
    {
        private static Random _random = new Random();

        public static int Roll()
        {
            int number = _random.Next(1, 7);
            Console.WriteLine($"Le dé affiche {number}");
            return number;
        }
    }
}
