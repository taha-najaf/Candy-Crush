using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
            showPendingMatches();
        }
        private void ShowApplicants()
        {
            contestApplications = db.GetContestApplications(player.Id);
            var receiveds = contestApplications.Where(x => x.ReceiverId == player.Id);

            DataTable table = new DataTable();
            table.Columns.Add("ApplicantId");
            table.Columns.Add("Sender Name");
            table.Columns.Add("Sender Family");
            table.Columns.Add("Sender Code");

            foreach (var contestApplication in receiveds)
            {
                var sender = db.Players.FirstOrDefault(p => p.Id == contestApplication.SenderId);
                if (sender != null)
                {
                    // Add the applicant details to the table
                    table.Rows.Add(contestApplication.ApplicantId, sender.Name, sender.Family, sender.Code);
                }
            }

            CalDataGridview.DataSource = table;
            CalDataGridview.Refresh();
            
        }



        private void Acceptbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApplicantId.Text != string.Empty)
                {
                    int Aid = int.Parse(ApplicantId.Text);
                    var SellectedCA = contestApplications.Where(I => I.ApplicantId == Aid).FirstOrDefault();
                    if (SellectedCA != null && SellectedCA.ReceiverId != SellectedCA.SenderId)
                    {
                        Matches matches = new Matches(SellectedCA.SenderId, SellectedCA.ReceiverId);
                        db.AddMatch(matches);
                        db.RemoveContestApplication(SellectedCA);
                        db.SaveChanges();
                        MessageBox.Show("Contest application accepted!");
                        ShowApplicants();
                        MainGame mainGame = new MainGame(matches, player,false);
                        mainGame.ShowDialog();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void RejectAPbtn_Click(object sender, EventArgs e)
        {
            int Aid = int.Parse(ApplicantId.Text);
            var SellectedCA = contestApplications.Where(I => I.ApplicantId == Aid).FirstOrDefault();
            db.RemoveContestApplication(SellectedCA) ;
            db.SaveChanges();
            MessageBox.Show("Contest application rejected!");
            ShowApplicants() ;
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
            FriendsDatagridview.Refresh();

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            string code = Friendcodetxt.Text;
            var friend = db.Players.FirstOrDefault(p => p.Code == code);
            if (friend != null)
            {
                ContestApplication contestApplication = new ContestApplication(player.Id, friend.Id);
                db.AddContestApplication(contestApplication);
                db.SaveChanges();
                MessageBox.Show("Contest application sent!");
            }
            else
            {
                MessageBox.Show("Friend not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        private void showPendingMatches()
        {

            var  matches=db.GetMatches(player.Id);
            var pendingMatch=matches.Where(m=>m.Player1Id == player.Id && m.Player2Hasplayed ==true && m.Player1HasPlayed==false);
            if (pendingMatch != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Match_Id");
                table.Columns.Add("opponent Name");
                table.Columns.Add("opponent Family");
                table.Columns.Add("opponent score");

               // var opponents = pendingMatch.Select(m => m.Player1Id);
                foreach (var match in pendingMatch)
                {
                    var opponent=db.GetPlayer(match.Player2Id);
                    table.Rows.Add(match.MatchId,opponent.Name,opponent.Family,match.Player2Score);
                }
                PendingMatchDataGridview.DataSource = table;
                PendingMatchDataGridview.Refresh();
            }


        }
        private void FriendsDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pendingbtn(object sender, EventArgs e)
        {
            try
            {

                if (MatchIDtxt.Text != string.Empty)
                {
                    int id = int.Parse(MatchIDtxt.Text);
                    var match = db.Matches.FirstOrDefault(x => x.MatchId == id);
                    if (match != null)
                    {
                        
                        MainGame mainGame = new MainGame(match, player,true);
                        mainGame.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Match not found or invalid id,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team_Alone team_Alone = new Team_Alone(player);
            team_Alone.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
