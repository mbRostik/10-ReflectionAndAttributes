using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.Quality
{
    internal class Regular : QualityJew
    {
        int buffquality = 2;

        public override int Buffquality { get => buffquality; }
    }
}
