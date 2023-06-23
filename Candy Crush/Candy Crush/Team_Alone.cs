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
        DataBase db=new DataBase();
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
            MainGame mainGame = new MainGame(player);
            mainGame.Show();
            this.Hide();
        }

        private void PlayGroupbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your code for playing with your friends is {player.Code}","Code",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Hide();
            GroupGameForm gameForm = new GroupGameForm(player);
            gameForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            PlayerPanel playerPanel=new PlayerPanel(player);
            playerPanel.Show();
            this.Hide();
        }

        private void Logout(object sender, EventArgs e)
        {
            Loginfrm loginfrm = new Loginfrm();
            loginfrm.ShowDialog();
            this.Hide();
        }
    }
}
