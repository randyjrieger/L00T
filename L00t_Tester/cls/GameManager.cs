using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootClasses
{
    public static class GameManager
    {
        public static List<player> Players = new List<player>();
        public static int CurrentPlayerID { get; set; }
        public static player CurrentPlayer { get; set; }
        public static player WinningPlayer { get; set; }
        public static int MaxPointsEarned { get; set; }
        public static card CurrentCard { get; set; }
        public static bool WaitingToSelectCharacter { get; set; }
        public static void NextPlayer()
        {
            CurrentPlayerID++;

            if (CurrentPlayerID == 5)
                CurrentPlayerID = 1;
        }
    }
}
