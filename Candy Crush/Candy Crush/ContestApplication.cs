using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class ContestApplication
    {
        [Key]
        public int ApplicantId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
     

        public ContestApplication()
        {
        }
        public ContestApplication( int userId,int friendId)
        {
            SenderId = userId;
            ReceiverId = friendId;
        }
    }
}
