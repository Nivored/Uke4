using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    class Gengar : Pokemon
    {
        public Gengar() : base("Gengar", "Ghost", "Poison", 340, 200, 180)
        {
            Attacks = new Attack[]
            {
                new Attack("Shadow Ball", 80, 0, "Ghost"),
                new Attack ("Shadow Claw", 70, 0, "Ghost"),
                new Attack ("Sludge Bomb", 90, 0, "Poison"),
                new Attack ("Poison Jab", 80, 0, "Poison"),
            };
            WeakTo = new string[] { "Ghost", "Dark", "Ground", "Psychic" };
            //Weakness = new WeakTo[]
            //{
            //    new WeakTo("Ghost"),
            //    new WeakTo("Psychic"),
            //    new WeakTo("Dark"),
            //    new WeakTo("Ground"),
            //};
        }
    }
}