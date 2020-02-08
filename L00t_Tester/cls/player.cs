using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootClasses
{
    public enum ClassName
    {
        wizard = 1,
        warrior = 2,
        thief = 3,
        cleric = 4
    }

    public class player
    {
        public int id = 0;
        public List<card> hand = new List<card>();
        public List<card> lootHand = new List<card>();
        public List<loot> hoard = new List<loot>();

        public ClassName classType { get; set; }
        public int Points { get; set; }

        public player()
        {
            Points = 0;
        }
    }
}
