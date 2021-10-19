using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    [Table("Teams")]
    public class Team
    {
        public int Id { get; set; }

        [Required,MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Color> Colors { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
