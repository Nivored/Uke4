using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    class Gardevoir : Pokemon
    {
        public Gardevoir() : base("Gardevoir", "Psychic", "Fairy", 320, 115, 200) 
        {
            Attacks = new Attack[]
            {
                new Attack("Psychic", 80, 0, "Psychic"),
                new Attack("Draning kiss", 50, 25, "Fairy"),
                new Attack("Dazzling Gleam", 80, 0, "Fairy"),
                new Attack("Psybeam", 65, 0, "Psychic"),
            };
            WeakTo = new string[] { "Bug", "Ghost", "Dark", "Poison", "Steel" };
            //Weakness = new WeakTo[]
            //{
            //    new WeakTo("Bug"),
            //    new WeakTo("Ghost"),
            //    new WeakTo("Dark"),
            //    new WeakTo("Poison"),
            //    new WeakTo("Steel"),
            //};
        }

    }
}
