using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.RarityW
{
    internal class RareW : RarityWeapon
    {
        private int buffRarity = 3;
        private string nameRarity = "Rare";

        public override string NameRarity { get => nameRarity; }
        public override int BuffRarity { get => buffRarity; }
    }
}
