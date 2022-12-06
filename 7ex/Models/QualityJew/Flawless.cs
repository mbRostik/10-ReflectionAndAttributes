using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.Quality
{
    internal class Flawless : QualityJew
    {
        int buffquality = 10;

        public override int Buffquality { get => buffquality; }
    }
}
