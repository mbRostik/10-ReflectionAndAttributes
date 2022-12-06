using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7ex.Models.Quality;

namespace _7ex.Models.Jewels
{
    internal class Jewel
    {
        private int strength=0;
        private int vitality=0;
        private int agility=0;
        private string name = "";
        public virtual string Name { get => name; }
        public virtual int Strength { get => strength; set => strength = strength + value; }
        public virtual int Vitality { get => vitality; set => vitality = vitality + value; }
        public virtual int Agility { get => agility; set => agility = agility + value; }

        public virtual void JewelQual(QualityJew a)
        {
            Strength = a.Buffquality;
            Vitality = a.Buffquality;
            Agility = a.Buffquality;
        }
    }
}
