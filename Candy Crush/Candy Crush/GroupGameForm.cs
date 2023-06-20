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
    public partial class GroupGameForm : Form
    {
        private DataBase db=new DataBase();
        private Players player;
        private List<ContestApplication> contestApplications=new List<ContestApplication>();
        public GroupGameForm(Players Player)
        {
            InitializeComponent();
            player = Player;

        }

        private void GroupGameForm_Load(object sender, EventArgs e)
        {
            contestApplications =db.GetContestApplications(player.Id);
            CalDataGridview.DataSource = contestApplications;
        }

        private void Acceptbtn_Click(object sender, EventArgs e)
        {
            if (ApplicantId.Text!=string.Empty)
            {
                int Aid = int.Parse(ApplicantId.Text);
                var SellectedCA= contestApplications.Where(I=>I.ApplicantId==Aid).FirstOrDefault();
                if (SellectedCA!=null)
                {
                    Matches matches = new Matches(SellectedCA.UserId,SellectedCA.FriendId);
                    db.AddMatch(matches);
                    db.RemoveContestApplication(SellectedCA);
                    MessageBox.Show("Contest application accepted!");
                }
            }
        }

        private void RejectAPbtn_Click(object sender, EventArgs e)
        {
            int Aid = int.Parse(ApplicantId.Text);
            var SellectedCA = contestApplications.Where(I => I.ApplicantId == Aid).FirstOrDefault();
            db.RemoveContestApplication(SellectedCA) ;
            MessageBox.Show("Contest application rejected!");
        }
    }
}
