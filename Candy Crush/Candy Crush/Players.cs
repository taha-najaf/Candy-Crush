using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int record { get ; set; }
        public int Number_Of_Games_Played { get; set;}
        public List <Players> Friends { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public string Code { get; set; }
      //  public List <Matches> Matches { get; set; }=new List<Matches>();
        public Players() { }
        public Players( string name, string family,string username,string password,string code)
        {
            
            Name = name;
            Family = family;
            Username = username;
            Password = password;
            Wins = 0;
            Loses = 0;
            record = 0;
            Code = code;
            

        }
    }
}
