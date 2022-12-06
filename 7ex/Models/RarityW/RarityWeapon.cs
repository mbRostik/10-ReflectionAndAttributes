using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.RarityW
{
    internal class RarityWeapon
    {
        private int buffRarity;
        private string nameRarity = "";

        public virtual string NameRarity { get => nameRarity; }
        public virtual int BuffRarity { get => buffRarity; }
    }
}
