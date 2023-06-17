using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class DataBase:DbContext
    {
        public DataBase() : base("name=DBCD")//connection string 
        { }
        //list of objects 
        public DbSet<Players> Players { get; set; }
    }
}
