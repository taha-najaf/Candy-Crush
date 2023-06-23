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
    public partial class Registerfrm : Form
    {
        DataBase db=new DataBase();
        public Registerfrm()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string family = familytxt.Text;
            string password=passwordtxt.Text;
            string username=usernametxt.Text;
            string code=GenerateRandomCode();
            Players player = new Players(name,family,username,password,code);

            
            db.Players.Add(player);
            db.SaveChanges();
            MessageBox.Show($"You are registered and your code is:{player.Code} !","Register",MessageBoxButtons.OK);            
            Team_Alone team_Alone =new Team_Alone(player);
            team_Alone.ShowDialog();
            this.Hide();

        }

        private void Registerfrm_Load(object sender, EventArgs e)
        {

        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string code = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return code;
        }

    }
}
