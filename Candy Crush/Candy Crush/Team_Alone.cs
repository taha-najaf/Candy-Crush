using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candy_Crush
{
    public partial class Team_Alone : Form
    {
        private Players player;
        public Team_Alone(Players player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void Team_Alone_Load(object sender, EventArgs e)
        {

        }

        private void SinglePlaybtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayGroupbtn_Click(object sender, EventArgs e)
        {
            player.Groupgame = true;
            this.Close();
        }
    }
}
