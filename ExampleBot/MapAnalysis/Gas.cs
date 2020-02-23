using SC2APIProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMeBotNS.MapAnalysis
{
    class Gas
    {
        public Point Pos { get; set; }
        public ulong Tag { get; set; }
        public bool Available { get; set; }
        public bool CanBeGathered { get; set; }
        public Unit Unit { get; set; }
    }
}
