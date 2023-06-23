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
    public partial class PlayerPanel : Form
    {
        private Players Player;
        DataBase db=new DataBase();
        public PlayerPanel(Players Player)
        {
            InitializeComponent();
            this.Player = Player;
        }

        private void PlayerPanel_Load(object sender, EventArgs e)
        {
            showtableOfPlayer();
            showFriendInfo();
            showMatch();
            if (FriendsDatagridview.Rows.Count == 0)
            {
                Friendlbl.Text = "No friends found.";
            }
            else
            {
                Friendlbl.Text = string.Empty;
              
            }

            if (MatchDGV.Rows.Count == 0)  Matchlbl.Text = "No Matches found.";
            else
                Matchlbl.Text = string.Empty;


        }
        private void showtableOfPlayer()
        {
            DataTable table= new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Family");
            table.Columns.Add("Username");
            table.Columns.Add("Password");
            table.Columns.Add("Highest Record");
            table.Columns.Add("NOG");
            table.Columns.Add("Wins");
            table.Columns.Add("Loss");
            table.Columns.Add("Code");

            table.Rows.Add(Player.Id, Player.Name, Player.Family, Player.Username, Player.Password, Player.record,
                Player.Number_Of_Games_Played, Player.Wins, Player.Loses, Player.Code);
            InfODataGridView.DataSource = table;
            InfODataGridView.Refresh();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string code = Codetxt.Text;
            var friend = db.Players.FirstOrDefault(p => p.Code == code);
            if (friend != null)
            {
                bool isFriendAlreadyAdded = db.Friends.Any(f => f.PlayerId == Player.Id && f.FriendId == friend.Id);
                if (!isFriendAlreadyAdded)
                {
                    db.AddFriend(Player.Id, friend.Id);
                    db.AddFriend(friend.Id, Player.Id);
                    db.SaveChanges();
                    MessageBox.Show(" Friend added successfully","Add friend",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    showFriendInfo();

                }
                else
                {
                    MessageBox.Show("Friend is already in the list","Old friend",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show( "Friend not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
        }
        private void showFriendInfo()
        {
            List <Players> players= new List<Players>();
            players=db.GetFriends(Player.Id);
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Family");
            table.Columns.Add("Highest Record");
            table.Columns.Add("NOG");
            table.Columns.Add("Wins");
            table.Columns.Add("Loss");
            table.Columns.Add("Code");

            foreach (var player in players)
            {
                table.Rows.Add(player.Id, player.Name, player.Family, player.record, player.Number_Of_Games_Played, player.Wins
                    , player.Loses, player.Code);
            }
            FriendsDatagridview.DataSource = table;
            InfODataGridView.Refresh();

        }

        private void showMatch()
        {
            List <Matches> matches= new List<Matches>();
            matches = db.GetMatches(Player.Id);
            int winnerScore=0;
            int losserScore=0;

            DataTable table= new DataTable();
            table.Columns.Add("Match Id");
            table.Columns.Add("Winner Name");
            table.Columns.Add("Winner Score");
            table.Columns.Add("Losser Name");
            table.Columns.Add("Losser Score");
            table.Columns.Add("Draw");

            foreach (var match in matches)
            {
                if (match.Player1HasPlayed && match.Player2Hasplayed)
                {
                    if (match.Player1Score > match.Player2Score)
                    {
                        match.SetWinnerAndLoser(match.Player1Id, match.Player2Id);
                        winnerScore = match.Player1Score;
                        losserScore = match.Player2Score;
                    }
                    else if (match.Player1Score < match.Player2Score)
                    {
                        match.SetWinnerAndLoser(match.Player2Id, match.Player1Id);
                        losserScore = match.Player1Score;
                        winnerScore = match.Player2Score;
                    }
                    else
                    {
                        match.SetDraw();
                        winnerScore = losserScore = match.Player1Score;
                    }

                    var winner = db.Players.Find(match.WinnerId);
                    string winnerName = winner.Name + ' ' + winner.Family;
                    var loser = db.Players.Find(match.LoserId);
                    string loserName = loser.Name + " " + loser.Family;

                    table.Rows.Add(match.MatchId, winnerName, winnerScore, loserName, losserScore, match.IsDraw);
                    
                }
            }
            db.SaveChanges();
            MatchDGV.DataSource = table;
            InfODataGridView.Refresh();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            Team_Alone team_Alone =  new Team_Alone(Player);
            team_Alone.ShowDialog();
            
        }
    }
}
