﻿using System;
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
            Players player = new Players(name,family,username,password);
            
        }

        private void Registerfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
