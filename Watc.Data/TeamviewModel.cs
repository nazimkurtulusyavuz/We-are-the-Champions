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
        public string teamPlayers => $"{PlayersText()}"; 
        public string teamColors => ColorText(); 

        public string PlayersText()
        {
            List<string> lst = new List<string>();
            foreach (Player player in Players)
            {
                 lst.Add(player.PlayerName);
            }
            return string.Join(",",lst);
        }
        public string ColorText()
        {
            List<string> lst = new List<string>();
            foreach (Color color in Colors)
            {
                lst.Add(color.ColorName);
            }
            return string.Join(",", lst);
        }


        //public string MatchScore => $"{MatchScoreText()}";

        //private string MatchScoreText()
        //{
        //    return (Score1 == null ? "?" : Score1.ToString()) + " - " + (Score2 == null ? "?" : Score2.ToString());
        //}

    }
}
