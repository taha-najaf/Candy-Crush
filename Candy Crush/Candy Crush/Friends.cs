using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace Candy_Crush
{
    [Table("Friends")]
    public class Friends
    {
        [Key]
        public int FriendshipId { get; set; }
        public int PlayerId { get; set; }
        public int FriendId { get; set; }
    }
}
