using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootClasses
{
    public enum cardType
    {
        monster = 1,
        treasure = 2,
        attack = 3,
        trip = 4,
        twistoffate = 5,
        yoursismine = 6
    };

    public class card
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ClassName AssociatedClass { get; set; }
        public cardType Type { get; set; }


    }
}
