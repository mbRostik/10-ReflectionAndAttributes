using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.RarityW
{
    internal class EpicW : RarityWeapon
    {
        private int buffRarity = 5;
        private string nameRarity = "Epic";

        public override string NameRarity { get => nameRarity; }
        public override int BuffRarity { get => buffRarity; }
    }
}
