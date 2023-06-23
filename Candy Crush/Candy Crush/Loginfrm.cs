using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Candy_Crush
{
    public partial class Loginfrm : Form
    {
     
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Registerfrm frm = new Registerfrm();
            frm.ShowDialog();
            this.Hide();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string username=Usernametxt.Text;
            string password=Passwordtxt.Text;
            var player=db.Players.FirstOrDefault(p=> p.Username == username && p.Password == password);
            if (player != null)
            {
                MessageBox.Show("Login Successful!","Login",MessageBoxButtons.OK);
                this.Hide();
                Team_Alone team_Alone = new Team_Alone(player);
                team_Alone.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

    }
}
