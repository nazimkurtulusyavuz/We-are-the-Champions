using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    public class MatchviewModel
    {
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
        public string MatchDate { get; set; }
        public string MatchTime { get; set; }
        public string MatchScor { get; set; }
        public Match Match { get; set; }

    }
}
