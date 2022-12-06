
using _7ex.Models.Jewels;
using _7ex.Models.RarityW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7ex.Models.Weapons
{
    internal class Weapon
    {
        private int MaxDamage = 0;
        private int MinDamage = 0;
        private string name = "";
        private int strength = 0;
        private int vitality = 0;
        private int agility = 0;
        private List<Jewel> jewels = new List<Jewel>();
        private int maxsockets = 0;
        private string rarity="";
        protected virtual string Rarity { get => rarity; }
        public virtual void WeaponSetRarity(RarityWeapon a)
        {
            rarity = a.NameRarity;
            MinDamage *= a.BuffRarity;
            MaxDamage *= a.BuffRarity;
        }
        public virtual void Jewels(Jewel jewel)
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

        public virtual void DelJewels(int index)
        {
            if(jewels.Count == 0)
            {
                Console.WriteLine("There are any jewels");
                return;
            }
            else if (jewels.Count < index)
            {
                Console.WriteLine("Wrong number of socket");
                return;
            }
            Strength= (-1)*jewels[index-1].Strength;
            Agility = (-1) * jewels[index - 1].Agility;
            Vitality = (-1) * jewels[index - 1].Vitality;
            index--;
            jewels.RemoveAt(index);

        }
        protected virtual int GetMaxDamage { get => MaxDamage; }
        protected virtual int GetMinDamage { get => MinDamage; }

        protected virtual int Strength { get => strength; set => strength=strength + value; }
        protected virtual int Vitality { get => vitality; set => vitality = vitality + value; }
        protected virtual int Agility { get => agility; set => agility = agility + value; }

        public virtual string Name { get => name; set => name = value; }

        
        public override string ToString()
        {
            return Rarity+" "+Name + ": " + GetMinDamage + "-" + GetMaxDamage + " Damage" + "; Strength - "+Strength+", Vitality - "+ Vitality+ ", Agility - "+ Agility;
        }
    }
}
