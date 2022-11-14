using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    class Lycanroc : Pokemon
    {
        public Lycanroc() : base("Lycanroc", "Rock", "", 350, 100, 140)
        {
            Attacks = new Attack[]
            {
                new Attack("Stone Edge", 100, 0,"Rock"),
                new Attack("Crunch", 80, 0, "Dark"),
                new Attack("Rock Tomb", 60, 0, "Rock"),
                new Attack("Stomping Tantrum", 75, 0,"Ground"),
            };
            WeakToo = new string[] { "Water", "Grass", "Fighting", "Steel", "Ground" };
        }

    }
}
