using _7ex.Models.Jewels;
using _7ex.Models.RarityW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.Weapons
{
    internal class Knife:Weapon
    {
        private int MaxDamage = 4;
        private int MinDamage = 3;
        private int strength = 0;
        private int vitality = 0;
        private int agility = 0;
        private List<Jewel> jewels = new List<Jewel>();
        private int maxsockets = 2;
        private string rarity = "";
        protected override string Rarity { get => rarity; }
        public override void WeaponSetRarity(RarityWeapon a)
        {
            rarity = a.NameRarity;
            MinDamage *= a.BuffRarity;
            MaxDamage *= a.BuffRarity;
        }

        public override void DelJewels(int index)
        {
            if (jewels.Count == 0)
            {
                Console.WriteLine("There are any jewels");
                return;
            }
            else if (jewels.Count < index)
            {
                Console.WriteLine("Wrong number of socket");
                return;
            }
            Strength = (-1) * jewels[index - 1].Strength;
            Agility = (-1) * jewels[index - 1].Agility;
            Vitality = (-1) * jewels[index - 1].Vitality;
            index--;
            jewels.RemoveAt(index);

        }
        protected override int Strength { get => strength; set => strength = strength + value; }
        protected override int Vitality { get => vitality; set => vitality = vitality + value; }
        protected override int Agility { get => agility; set => agility = agility + value; }
        protected override int GetMaxDamage { get => MaxDamage; }
        protected override int GetMinDamage { get => MinDamage; }

        public override void Jewels(Jewel jewel)
        {
            if (jewels.Count >= maxsockets)
            {
                Console.WriteLine("Limit of sockets");
                return;
            }
            jewels.Add(jewel);

            Strength = jewel.Strength;
            Vitality = jewel.Vitality;
            Agility = jewel.Agility;
        }
    }
}
