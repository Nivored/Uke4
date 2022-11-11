using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArvPokemon
{
    internal class Fight
    {
        private List<Pokemon> wildPokemon = new List<Pokemon>()
        {
            new Gardevoir(),
            new Lucario(),
            new Gengar(),
            new Lycanroc()
        };
        private List<Pokemon> wildPokemon2 = new List<Pokemon>()
        {
            new Gardevoir(),
            new Lucario(),
            new Gengar(),
            new Lycanroc()
        };

        public void StartFight()
        {
            Random random = new Random();
            var randomIndex1 = random.Next(wildPokemon.Count);
            var randomIndex2 = random.Next(wildPokemon2.Count);
            var randomPokemon1 = wildPokemon[randomIndex1];
            var randomPokemon2 = wildPokemon2[randomIndex2];
            var HasHp = true;

            while (HasHp)
            {
                if (HasHp == false) { break; }

                randomPokemon1.Info();
                randomPokemon2.Info();

                if (randomPokemon2.Speed > randomPokemon1.Speed)
                {
                    randomPokemon2.Attack(randomPokemon1);
                    if (randomPokemon1.HasFainted != false)
                    {
                        randomPokemon1.Attack(randomPokemon2);
                    }
                }
                else
                {
                    randomPokemon1.Attack(randomPokemon2);
                    if (randomPokemon2.HasFainted != false)
                    {
                        randomPokemon2.Attack(randomPokemon1);
                    }
                }
                if (randomPokemon1.Health <= 0)
                {
                    Console.WriteLine($"player 1: {randomPokemon1.Name} Fainted");
                    HasHp = randomPokemon1.HasFainted;
                }
                if (randomPokemon2.Health <= 0)
                {
                    Console.WriteLine($"Player 2: {randomPokemon2.Name} Fainted");
                    HasHp = randomPokemon2.HasFainted;
                }
            }
        }
    }
}