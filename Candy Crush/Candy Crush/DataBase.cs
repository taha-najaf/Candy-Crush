using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Candy_Crush
{
    public class DataBase:DbContext
    {
        public DataBase() : base("name=DBCD")//connection string 
        {
            
        }
        //list of objects 
        
        public DbSet<Players> Players { get; set; }
        public DbSet <Friends> Friends { get; set; }
        public DbSet <Matches> Matches { get; set; }
        public DbSet <ContestApplication> contestApplications { get; set; }

        //Player methods
        public Players GetPlayer(int playerId)
        {
            return Players.FirstOrDefault(p => p.Id == playerId);
        }
        // friends table methods
        public void AddFriend(int playerId, int friendId)
        {
            Friends.Add(new Friends { PlayerId = playerId, FriendId = friendId });
            SaveChanges();
        }

        public void RemoveFriend(int friendshipId)
        {
            var friend = Friends.Find(friendshipId);
            if (friend != null)
            {
                Friends.Remove(friend);
                SaveChanges();
            }
        }

        public List<Players> GetFriends(int playerId)
        {
            return Players
                .Where(p => Friends.Any(f => f.PlayerId == playerId && f.FriendId == p.Id))
                .ToList();
        }

        //Match table
        public void AddMatch(Matches match)
        {
            Matches.Add(match);
            SaveChanges();
        }
        public List<Matches> GetMatches(int playerId)
        {
            return Matches
                .Where(m => m.Player1Id == playerId || m.Player2Id == playerId)
                    .ToList();
        }
        //contest application methods
        public void AddContestApplication(ContestApplication contestApplication)
        {
            contestApplications.Add(contestApplication);
            SaveChanges() ;
        }
        public void RemoveContestApplication (ContestApplication contestApplication)
        {
            contestApplications.Remove(contestApplication);
            SaveChanges() ;
        }

        public List<ContestApplication> GetContestApplications(int userId)
        {
            return contestApplications.Where(c => c.ReceiverId == userId && c.SenderId != userId).ToList();
        }

    }


}
