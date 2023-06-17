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

        public string Color { get; set; }
        public Image Image { get; set; }

        public Candy(string color, Image image)
        {
            Color = color;
            Image = image;
        }
    }
}
