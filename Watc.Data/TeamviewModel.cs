using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    public class TeamviewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Color> Colors { get; set; }
        public virtual List<Player> Players { get; set; }
        public virtual List<Match> Matches { get; set; }
        
        public string players => PlayersText();

        private string PlayersText()
        {
            string x = "";
            foreach (Player player in Players)
            {
                x += "," + player.PlayerName;
            }
            return x;
        }



        //public string MatchScore => $"{MatchScoreText()}";

        //private string MatchScoreText()
        //{
        //    return (Score1 == null ? "?" : Score1.ToString()) + " - " + (Score2 == null ? "?" : Score2.ToString());
        //}

    }
}
