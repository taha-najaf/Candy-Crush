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
    public partial class MainGame : Form
    {
        private CandyCrushBoard candyCrushBoard;
        public MainGame(Players players)
        {

            InitializeComponent();
            candyCrushBoard = new CandyCrushBoard(9, 9);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            candyCrushBoard.InitializeBoard(pictureBoxBoard);
            timer1.Start();
        }

        private int elapsedTime = 0;
        private const int totaltime = 120;//2 minutes in seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            int remainigTime=totaltime-elapsedTime;

            //update time
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainigTime);
            string timeString=timeSpan.ToString(@"mm\:ss");
            lbltime.Text = timeString;

            if(remainigTime <=0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up!"); 
                pictureBoxBoard.Enabled = false;
            }

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
