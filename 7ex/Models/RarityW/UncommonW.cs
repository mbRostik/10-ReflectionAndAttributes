using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.RarityW
{
    internal class UncommonW : RarityWeapon
    {
        private int buffRarity = 2;
        private string nameRarity = "Uncommon";

        public override string NameRarity { get => nameRarity; }
        public override int BuffRarity { get => buffRarity; }
    }
}
