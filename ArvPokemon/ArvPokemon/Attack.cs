using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    internal class Attack
    {
        public string Name { get; set; }
        public int Dmg { get; set; }
        public int LifeSteal { get; set; }
        public string Type { get; set; }

        public Attack(string name, int dmg, int lifeSteal, string type)
        {
            Name = name;
            Dmg = dmg;
            LifeSteal = lifeSteal;
            Type = type;
        }
    }
}
