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
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public string Draw { get; set; }
        public int? LoserId { get; set; }
        public int? WinnerId { get; set; }
        public bool IsDraw { get; set; }


        public void SetWinnerAndLoser(int winnerId, int loserId)
        {
            WinnerId = winnerId;
            LoserId = loserId;
            IsDraw = false; // Reset IsDraw flag when a winner and loser are set
        }

        public void SetDraw()
        {
            WinnerId = null; // Reset winner when match is a draw
            LoserId = null; // Reset loser when match is a draw
            IsDraw = true;
        }
    }

}
