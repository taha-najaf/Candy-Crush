using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Crush
{
    public class Candy
    {
        public string Type { get; set; }
        public Point Position { get; set; }

        // Constructor
        public Candy(string type, Point position)
        {
            Type = type;
            Position = position;
        }
    }
}
