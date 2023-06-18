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
        public void AddMatch(int winerId, int loserId)
        {
            Matches.Add(new Matches { WinnerId=winerId,LoserId=loserId });
            SaveChanges();
        }
        public List<Matches> GetMatches(int playerId)
        {
            return Matches
                .Where(m => m.WinnerId == playerId || m.LoserId == playerId)
                    .ToList();
        }

    }
}
