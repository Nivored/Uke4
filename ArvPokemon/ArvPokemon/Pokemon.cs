using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ArvPokemon;

namespace ArvPokemon
{
    abstract class Pokemon
    {
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public  Attack[] Attacks { get; set; }
        public string[] WeakToo { get; set; }
        public int Defence { get; set; }
        public bool HasFainted;

        protected Pokemon(string name, string type1, string type2, int health, int speed, int defence)
        {
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Health = health;
            Speed = speed;
            Attacks = new Attack[]{};
            string[] WeakToo = new string[]{};
            Defence = defence;
            HasFainted = true;
        }

        public void Attack(Pokemon opponent) // random attack
        {
            Random random = new Random();
            var randomIndex = random.Next(Attacks.Length);
            var randomAttack = Attacks[randomIndex];

            if (opponent.WeakToo.Contains(randomAttack.Type))
            {
                if (randomAttack.LifeSteal >= 1)
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg*2}");
                    opponent.LoosHealth(randomAttack.Dmg * 2);
                    Health += randomAttack.LifeSteal * 2;
                    Console.WriteLine($"{Name} was healed for {randomAttack.LifeSteal*2}");
                    CheckPokemonStatus(opponent);
                }
                else
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg*2}");
                    opponent.LoosHealth(randomAttack.Dmg * 2);
                    CheckPokemonStatus(opponent);
                }
            }
            else if (opponent.Type1.Contains(randomAttack.Type) || opponent.Type2.Contains(randomAttack.Type))
            {
                if (randomAttack.LifeSteal >= 1)
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg/2}");
                    opponent.LoosHealth(randomAttack.Dmg/2);
                    Health += randomAttack.LifeSteal/2;
                    Console.WriteLine($"{Name} was healed for {randomAttack.LifeSteal/2}");
                    CheckPokemonStatus(opponent);
                }
                else
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg/2}");
                    opponent.LoosHealth(randomAttack.Dmg/2);
                    CheckPokemonStatus(opponent);
                }
            }
            else
            {
                if (randomAttack.LifeSteal >= 1)
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg}");
                    opponent.LoosHealth(randomAttack.Dmg);
                    Health += randomAttack.LifeSteal;
                    Console.WriteLine($"{Name} was healed for {randomAttack.LifeSteal}");
                    CheckPokemonStatus(opponent);
                }
                else
                {
                    Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg}");
                    opponent.LoosHealth(randomAttack.Dmg);
                    CheckPokemonStatus(opponent);
                }
            }
        }

        public void CheckPokemonStatus(Pokemon opponent)
        {
            if (opponent.Health <= 0)
            {
                opponent.HasFainted = false;
            }
        }

        public void Info()
        {
            Console.WriteLine($"{Name} {Health}");
        }

        public void LoosHealth(int Dmg)
        {
            Health -= Dmg;
        }
    }
}