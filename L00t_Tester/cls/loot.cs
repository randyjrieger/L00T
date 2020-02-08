using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootClasses
{
    public class loot
    {
        public int Worth { get; set; }
        public string Description { get; set; }

        public loot(int cardnumber)
        {
            if (cardnumber >= 1 && cardnumber <= 4)
            {
                Worth = 1;
                Description = "1";                  
            }
            else if (cardnumber >= 5 && cardnumber <= 6)
            {
                Worth = 2;
                Description = "2";
            }
            else if (cardnumber >= 7 && cardnumber <= 10)
            {
                Worth = 3;
                Description = "3";
            }
            else if (cardnumber >= 11 && cardnumber <= 12)
            {
                Worth = 5;
                Description = "5";
            }
            else if (cardnumber >= 13 && cardnumber <= 14)
            {
                Worth = 10;
                Description = "10";
            }
        }
    }
}
