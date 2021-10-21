using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    public class MatchviewModel
    {
        public int Id { get; set; }
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
        public string MatchDateTime { get; set; }
        public string MatchScore { get; set; }
        public Match Match { get; set; }



        //public int Id { get; set; }

        //public DateTime? MatchTime { get; set; }

        //public int? Score1 { get; set; }

        //public int? Score2 { get; set; }

        //public Result? Result { get; set; }

        //[ForeignKey("Team1")]
        //public int Team1Id { get; set; }
        //public virtual Team Team1 { get; set; }

        //[ForeignKey("Team2")]
        //public int Team2Id { get; set; }
        //public virtual Team Team2 { get; set; }
    }
}
