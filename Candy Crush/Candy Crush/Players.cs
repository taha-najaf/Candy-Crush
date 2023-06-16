using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class Players
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public int record { get ; set; }
        public int Number_Of_Games_Played { get; set;}
        public List <Players> Friends { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public List <Matches> Matches { get; set; }

    }
}
