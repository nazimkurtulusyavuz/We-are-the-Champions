using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watc.Data
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required,MaxLength(30)]
        public string ColorName { get; set; }

        [Required]
        public int Red { get; set; }

        [Required]
        public int Green { get; set; }

        [Required]
        public int Blue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }


    }
}
