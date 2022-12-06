using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ex.Models.Quality
{
    internal class Perfect : QualityJew
    {
        int buffquality = 5;

        public override int Buffquality { get => buffquality; }
    }
}
