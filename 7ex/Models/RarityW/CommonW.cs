using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.RarityW
{
    internal class CommonW:RarityWeapon
    {
        private int buffRarity=1;
        private string nameRarity = "Common";

        public override string NameRarity { get => nameRarity; }
        public override int BuffRarity { get => buffRarity; }
    }
}
