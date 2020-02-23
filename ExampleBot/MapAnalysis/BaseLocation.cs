using SC2APIProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMeBotNS.MapAnalysis
{
    class BaseLocation
    {
        public List<MineralField> MineralFields { get; internal set; } = new List<MineralField>();
        public List<Gas> Gasses { get; internal set; } = new List<Gas>();
        public Point2D Pos { get; set; }

    }
}
