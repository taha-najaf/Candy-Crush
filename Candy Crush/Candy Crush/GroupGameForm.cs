using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            ShowApplicants();
            showFriendInfo();
            if (FriendsDatagridview.Rows.Count == 0)
                Friendlbl.Text = "No friends found.";
            else
              Friendlbl.Text = string.Empty;

 
        }
        private void ShowApplicants()
        {
            contestApplications = db.GetContestApplications(player.Id);
            DataTable table = new DataTable();
            table.Columns.Add("ApplicantId");
            table.Columns.Add("Sender Name");
            table.Columns.Add("Sender Family");
            table.Columns.Add("Sender Code");
            var FriendIds =contestApplications.Select(x => x.FriendId).ToList();
            foreach (var contestApplication in contestApplications)
            {
                var sender = db.Players.FirstOrDefault(p => p.Id == contestApplication.FriendId);
                if (sender != null)
                {
                    // Add the applicant details to the table
                    table.Rows.Add(contestApplication.ApplicantId, sender.Name, sender.Family, sender.Code);
                }
            }
            CalDataGridview.DataSource=table;

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

        private void showFriendInfo()
        {
            List<Players> players = new List<Players>();
            players = db.GetFriends(player.Id);
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Family");
            table.Columns.Add("Code");

            foreach (var player in players)
            {
                table.Rows.Add(player.Id, player.Name, player.Family, player.Code);
            }
            FriendsDatagridview.DataSource = table;

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            string code = Friendcodetxt.Text;
            var friend = db.Players.FirstOrDefault(p => p.Code == code);
            if (friend != null)
            {
                ContestApplication contestApplication = new ContestApplication(player.Id, friend.Id);
                db.AddContestApplication(contestApplication);
                MessageBox.Show("Contest application sent!");
            }
            else
            {
                MessageBox.Show("Friend not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
