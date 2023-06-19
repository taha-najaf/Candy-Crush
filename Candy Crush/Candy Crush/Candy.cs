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

        public Point Position { get; set; }
        public Image Image { get; set; }

        public Candy() { }
        public Candy(Point point, Image image)
        {
            Position = point;
            Image = image;
        }
        private string[] candies = { "Blue", "Orange", "Green", "Yellow", "Red", "Purple" };
        public string GetRandomCandy()
        {
            Random random = new Random();
            int index = random.Next(candies.Length);
            return "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\" + candies[index] + ".png";
        }
    }
}
