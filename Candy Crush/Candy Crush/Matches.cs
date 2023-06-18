using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class Matches
    {
        [Key]
        public int MatchId { get; set; }
        public int WinnerId { get; set; }
        public string Draw { get; set; }
        public int LoserId { get; set; }

    }
}
