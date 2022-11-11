using System;
using System.Collections.Generic;
using System.Linq;
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
        //public WeakTo[] Weakness { get; set; }
        public string[] WeakTo { get; set; }
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
            //Weakness = new WeakTo[] {};
            string[] WeakTo = new string[]{};
            Defence = defence;
            HasFainted = true;
        }

        public void Attack(Pokemon opponent) // random attack
        {
            Random random = new Random();
            var randomIndex = random.Next(Attacks.Length);
            var randomAttack = Attacks[randomIndex];

            var attack = randomAttack.Type.Select(v => v.Equals(WeakTo));
                if (attack == null)
                {
                    if (randomAttack.LifeSteal >= 1)
                    {
                        Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg *2}");
                        opponent.LoosHealth(randomAttack.Dmg * 2);
                        Health += randomAttack.LifeSteal * 2;
                        Console.WriteLine($"{Name} was healed for {randomAttack.LifeSteal}");
                        CheckPokemonStatus(opponent);
                    }
                    else
                    {
                        Console.WriteLine($"{Name} used {randomAttack.Name} and hit for {randomAttack.Dmg *2}");
                        opponent.LoosHealth(randomAttack.Dmg * 2);
                        CheckPokemonStatus(opponent);
                    }
                }
                else if (attack != null)
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