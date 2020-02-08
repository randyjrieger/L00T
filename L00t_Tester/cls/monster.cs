using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootClasses
{

    public enum MonsterType
    {
        goblin = 1,
        troll = 2,
        kobold = 3,
        bandit = 4
    }

    public class monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public MonsterType Type { get; set; }

        public monster(int roll)
        {
            SetMonsterType(roll);
            Name = Type.ToString().ToUpper();
        }

        public void SetMonsterType(int roll)
        {
            Type = (MonsterType)Enum.ToObject(typeof(MonsterType), roll);
        }
    }
}
