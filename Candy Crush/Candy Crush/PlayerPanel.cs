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
            List<Matches> matches = new List<Matches>();
            matches = db.GetMatches(Player.Id);
            DataTable table = new DataTable();

            table.Columns.Add("Match Id");
            table.Columns.Add("Player 1 Name");
            table.Columns.Add("Player 1 Score");
            table.Columns.Add("Player 2 Name");
            table.Columns.Add("Player 2 Score");
            table.Columns.Add("Result");

            foreach (var match in matches)
            {
                if (match.Player1HasPlayed && match.Player2Hasplayed)
                {
                    string player1Name = db.Players.Find(match.Player1Id).Name + " " + db.Players.Find(match.Player1Id).Family;
                    string player2Name = db.Players.Find(match.Player2Id).Name + " " + db.Players.Find(match.Player2Id).Family;

                    if (match.Player1Score > match.Player2Score)
                    {
                        match.SetWinnerAndLoser(match.Player1Id, match.Player2Id);

                        table.Rows.Add(match.MatchId, player1Name, match.Player1Score, player2Name, match.Player2Score, "Player 1 Wins");
                    }
                    else if (match.Player1Score < match.Player2Score)
                    {
                        match.SetWinnerAndLoser(match.Player2Id, match.Player1Id);

                        table.Rows.Add(match.MatchId, player1Name, match.Player1Score, player2Name, match.Player2Score, "Player 2 Wins");
                    }
                    else
                    {
                        match.SetDraw();

                        table.Rows.Add(match.MatchId, player1Name, match.Player1Score, player2Name, match.Player2Score, "Draw");
                    }
                }
            }

            db.SaveChanges();
            MatchDGV.DataSource = table;
            InfODataGridView.Refresh();
        }


        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Team_Alone team_Alone =  new Team_Alone(Player);
            team_Alone.ShowDialog();
            
        }
    }
}
