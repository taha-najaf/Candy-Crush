using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candy_Crush
{
    public class Matches
    {
        [Key]
        public int MatchId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int? LoserId { get; set; }
        public int? WinnerId { get; set; }
        public bool IsDraw { get; set; }

        public bool Player1HasPlayed { get; set; }
        public bool Player2Hasplayed { get; set; }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }


        public Matches( int player1Id, int player2Id)
        {
            Player1Id = player1Id;
            Player2Id = player2Id;
            WinnerId = null; // Initialize as null, indicating no winner yet
            LoserId = null; // Initialize as null, indicating no loser yet
            IsDraw = false; // Initialize as false, indicating not a draw yet
            Player1Score = 0;
            Player2Score = 0;
            Player1HasPlayed = false;
            Player2Hasplayed = false;
        }
        public void SetWinnerAndLoser(int winnerId, int loserId)
        {
            WinnerId = winnerId;
            LoserId = loserId;
            IsDraw = false; // Reset IsDraw flag when a winner and loser are set
        }

        public void SetDraw()
        {
            WinnerId = '-'; // Reset winner when match is a draw
            LoserId = '-'; // Reset loser when match is a draw
            IsDraw = true;
        }
        public Matches() { }
    }

}
