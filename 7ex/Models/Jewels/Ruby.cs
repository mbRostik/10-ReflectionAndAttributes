using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.Jewels
{
    internal class Ruby:Jewel
    {
        
        private int strength=7;
        private int vitality=5;
        private int agility=2;
        private string name = "Ruby";
        public override string Name { get => name; }
        public override int Strength { get => strength; set => strength = strength + value; }
        public override int Vitality { get => vitality; set => vitality = vitality + value; }
        public override int Agility { get => agility; set => agility = agility + value; }


    }
}
