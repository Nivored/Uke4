using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    class Lucario : Pokemon
    {
        public Lucario() : base("Lucario", "Fighting", "Steel", 400, 150, 220)
        {
            Attacks = new Attack[]
            {
                new Attack("Brick Brake", 75, 0, "Fighting"),
                new Attack("Aura Sphere", 80, 0, "Fighting"),
                new Attack("Metal Claw", 50, 0, "Steel"),
                new Attack("Meteor Mash", 90, 0, "Steel"),
            };
            WeakToo = new string[] { "Flying", "Psychic", "Fairy", "Fire", "Ground", "Rock" };
        }
    }
}
