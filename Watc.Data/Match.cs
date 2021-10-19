using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }

        public DateTime? MatchTime { get; set; }

        // DateTime?  => DateTime yapabılırsın en son => add-migration .. deyip database'de gonder => update-data...

        public int? Score1 { get; set; } //byte yapılsa daha ıyı olur30 byte  2,5554,554,554   80mb8bit 32 bit  24bit  * 1000000 24.000000  300mb

        public int? Score2 { get; set; }

        public Result? Result { get; set; }

        [ForeignKey("Team1")]
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }

        [ForeignKey("Team2")]
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }

        //public string MatchDateTime => $"{MatchTime?.ToString("HH:mm")}";


         
        //Asımla yapıldı


        //public string MatchDateTime => $"{MatchTime?.ToString("yyyy:MM:dd:dddd")}";

        //public string MatchScore => $"{MatchScoreText()}";

        //private string MatchScoreText()
        //{
        //    return (Score1 == null ? "?" : Score1.ToString()) + " - " + (Score2 == null ? "?" : Score2.ToString());
        //}


    }
}
