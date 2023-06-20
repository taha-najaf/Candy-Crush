﻿using System;
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
        public int FriendId { get; set; }
        public int UserId { get; set; }
        

        public ContestApplication( int userId,int friendId)
        {
            UserId = userId;
            FriendId = friendId;
        }
    }
}
