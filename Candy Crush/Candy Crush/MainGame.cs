﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Candy_Crush
{
    public partial class MainGame : Form
    {
        DataBase db=new DataBase();
        private PictureBox[,] board;
        private int rows = 9;
        private int columns = 9;
        private string[] candies = { "Blue", "Orange", "Green", "Yellow", "Red", "Purple" };
        private Random random;
        private Players Player;
        private int score=0;
        private bool groupgame=false;
        private Matches match = new Matches();
       
        public MainGame(Players players)
        {
            InitializeComponent();
            Player = players;
        }
        public MainGame(Matches matches,Players player)
        {
            InitializeComponent();
            Player = player;
            match = matches;
            groupgame=true;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            StartGame();
            timer1.Start();
            CrushTimer.Tick += TimerTick;
            CrushTimer.Start();
            MessageBox.Show("You shoul score 1500 or more to win the game");
            //this.FormClosing += MainGame_FormClosing;
            //SaveScore();
        }

        private void StartGame()
        {
            board = new PictureBox[rows, columns];
            random = new Random();

            int startX = (ClientSize.Width - columns * 50) / 2;
            int startY = (ClientSize.Height - rows * 50) / 2;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    PictureBox tile = new PictureBox();
                    tile.Name = r.ToString() + "-" + c.ToString();
                    tile.Width = 50;
                    tile.Height = 50;
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;
                    tile.ImageLocation = GetRandomCandy(r,c);
                    tile.AllowDrop = true; // Enable drag and drop

                    tile.MouseDown += TileMouseDown;
                    tile.MouseMove += TileMouseMove;
                    tile.MouseUp += TileMouseUp;
                    tile.DragEnter += TileDragEnter;
                    tile.DragDrop += TileDragDrop;

                    board[r, c] = tile;
                    Controls.Add(tile);

                    tile.Location = new System.Drawing.Point(startX + c * 50, startY + r * 50);
                }
            }
        }

        private string GetRandomCandy(int row, int col)
        {

            int index = random.Next(candies.Length);
            string candy = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\" + candies[index] + ".png";

            // Check if the candy matches the two candies before it in the same row
            if (col >= 2 && board[row, col - 1].ImageLocation == candy && board[row, col - 2].ImageLocation == candy)
            {
                return GetRandomCandy(row, col); // Try again
            }

            // Check if the candy matches the two candies before it in the same column
            if (row >= 2 && board[row - 1, col].ImageLocation == candy && board[row - 2, col].ImageLocation == candy)
            {
                return GetRandomCandy(row, col); // Try again
            }
            return candy;
        }

        private void TileMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox currTile = (PictureBox)sender;
                currTile.DoDragDrop(currTile, DragDropEffects.Move);
            }
        }

        private void TileMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox currTile = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                currTile.DoDragDrop(currTile, DragDropEffects.Move);
            }
        }

        private void TileMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox currentTile = (PictureBox)sender;
                PictureBox otherTile = GetNeighbor(currentTile);

                if (otherTile!=null && CheckValid())
                
                {
                    // Swap the image locations
                    string currentImg = currentTile.ImageLocation;
                    string otherImg = otherTile.ImageLocation;
                    currentTile.ImageLocation = otherImg;
                    otherTile.ImageLocation = currentImg;

                    //if (!CheckValid())
                    //{
                    //    // Swap back if not valid
                    //    currentTile.ImageLocation = currentImg;
                    //    otherTile.ImageLocation = otherImg;
                    //}
                }
            }
        }
        private PictureBox GetNeighbor(PictureBox tile)
        {
            int row = int.Parse(tile.Name.Split('-')[0]);
            int col = int.Parse(tile.Name.Split('-')[1]);

            // Check left neighbor
            if (col > 0 && !board[row, col - 1].ImageLocation.Contains("blank"))
            {
                return board[row, col - 1];
            }

            // Check right neighbor
            if (col < columns - 1 && !board[row, col + 1].ImageLocation.Contains("blank"))
            {
                return board[row, col + 1];
            }

            // Check top neighbor
            if (row > 0 && !board[row - 1, col].ImageLocation.Contains("blank"))
            {
                return board[row - 1, col];
            }

            // Check bottom neighbor
            if (row < rows - 1 && !board[row + 1, col].ImageLocation.Contains("blank"))
            {
                return board[row + 1, col];
            }

            return null; // No valid neighbor found
        }
        private void TileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void TileDragDrop(object sender, DragEventArgs e)
        {
            PictureBox targetTile = (PictureBox)sender;
            PictureBox sourceTile = (PictureBox)e.Data.GetData(typeof(PictureBox));

            // Swap the image locations
            string targetImg = targetTile.ImageLocation;
            string sourceImg = sourceTile.ImageLocation;
            targetTile.ImageLocation = sourceImg;
            sourceTile.ImageLocation = targetImg;

            // Check validity after swapping
            if (!CheckValid())
            {
                // Swap back if not valid
                targetTile.ImageLocation = targetImg;
                sourceTile.ImageLocation = sourceImg;
            }
        }

    private bool CheckValid()
        {
            // Check rows
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns - 2; c++)
                {
                    PictureBox candy1 = board[r, c];
                    PictureBox candy2 = board[r, c + 1];
                    PictureBox candy3 = board[r, c + 2];

                    if (candy1.ImageLocation == candy2.ImageLocation && candy2.ImageLocation == candy3.ImageLocation &&
                        !candy1.ImageLocation.Contains("blank"))
                    {
                        return true;
                    }
                }
            }

            // Check columns
            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows - 2; r++)
                {
                    PictureBox candy1 = board[r, c];
                    PictureBox candy2 = board[r + 1, c];
                    PictureBox candy3 = board[r + 2, c];

                    if (candy1.ImageLocation == candy2.ImageLocation && candy2.ImageLocation == candy3.ImageLocation &&
                        !candy1.ImageLocation.Contains("blank"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private int elapsedTime = 0;
        private const int totaltime = 120;//2 minutes in seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            int remainigTime = totaltime - elapsedTime;

            //update time
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainigTime);
            string timeString = timeSpan.ToString(@"mm\:ss");
            lbltime.Text = timeString;

            if (remainigTime <= 0)
            {
                timer1.Stop();
                MessageBox.Show($"Time is up! you can't have any more movement.Your score is :{lblscore.Text}","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                foreach (var item in board)
                {
                    item.Enabled = false;
                }

            }

        }


        private void CrushCandy()
        {
            CrushThree();
            
            lblscore.Text = score.ToString();
            //if (score >= 1500)
            //{
            //    foreach (var item in board)
            //    {
            //        item.Enabled = false;
            //    }
            //}

        }

        private void CrushThree()
        {
            // Check rows
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns - 2; c++)
                {
                    PictureBox candy1 = board[r, c];
                    PictureBox candy2 = board[r, c + 1];
                    PictureBox candy3 = board[r, c + 2];

                    if (candy1.ImageLocation == candy2.ImageLocation && candy2.ImageLocation == candy3.ImageLocation &&
                        !candy1.ImageLocation.Contains("blank"))
                    {
                        candy1.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        candy2.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        candy3.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        score += 30;
                    }
                }
            }

            // Check columns
            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows - 2; r++)
                {
                    PictureBox candy1 = board[r, c];
                    PictureBox candy2 = board[r + 1, c];
                    PictureBox candy3 = board[r + 2, c];

                    if (candy1.ImageLocation == candy2.ImageLocation && candy2.ImageLocation == candy3.ImageLocation &&
                        !candy1.ImageLocation.Contains("blank"))
                    {
                        candy1.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        candy2.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        candy3.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                        score += 30;
                        
                    }
                }
            }
            SlideCandy();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {

        }
        private void TimerTick(object sender, EventArgs e)
        {
            CrushCandy();
            SlideCandy();
            GenerateCandy();
        }

        private void SlideCandy()
        {
            for (int c = 0; c < columns; c++)
            {
                int emptyRowsCount = 0;
                for (int r = rows - 1; r >= 0; r--)
                {
                    PictureBox currentCandy = board[r, c];

                    if (currentCandy.ImageLocation.Contains("blank"))
                    {
                        emptyRowsCount++;
                        currentCandy.ImageLocation = GetRandomCandy(r, c);
                    }
                    else if (emptyRowsCount > 0)
                    {
                        PictureBox destinationCandy = board[r + emptyRowsCount, c];
                        destinationCandy.ImageLocation = currentCandy.ImageLocation;
                        currentCandy.ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\blank.png";
                    }
                }
            }
        }


        private void GenerateCandy()
        {
            for (int c = 0; c < columns; c++)
            {
                if (board[0, c].ImageLocation.Contains("blank"))
                {
                    board[0, c].ImageLocation = "D:\\programming\\Projects\\Candy Crush\\Candy Crush\\Images\\candy\\" + GetRandomCandy(0, c) + ".png";
                }
            }
        }

        private void SaveScore()
        {
            int currentScore = int.Parse(lblscore.Text);
            int gamesPlayed = Player.Number_Of_Games_Played + 1;

            using (var db = new DataBase())
            {
                var player = db.Players.Find(Player.Id); // Assuming there's an Id property for the player

                if (player != null)
                {
                    if (currentScore >player.record)
                        player.record = currentScore;
                    player.Number_Of_Games_Played = gamesPlayed;
                    if (currentScore >= 1500)
                        player.Wins++;
                    else
                        player.Loses++;

                    db.SaveChanges(); // Save changes to the database
                }
            }
        }
       

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (groupgame==true)
                SaveGroupScore();
            SaveScore();
            CrushTimer.Stop();
            this.Close();
            Team_Alone team_Alone =new Team_Alone(Player);
            team_Alone.ShowDialog();
            
        }

        private void Resetbtn_Click_1(object sender, EventArgs e)
        {
            // Reset score
            score = 0;
            lblscore.Text = "0";

            // Reset timer
            elapsedTime = 0;
            timer1.Start();

            // Reset candies on the board
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    board[r, c].ImageLocation = GetRandomCandy(r, c);
                }
            }
        }
        private void SaveGroupScore()
        {
            int currentScore = int.Parse(lblscore.Text);

            using (var db = new DataBase())
            {
                var matchInfo = db.Matches.Find(match.MatchId);
                if (matchInfo != null)
                {
                    if (matchInfo.Player1HasPlayed == false)
                    {
                        matchInfo.Player1Id = Player.Id;
                        matchInfo.Player1Score = currentScore;
                        matchInfo.Player1HasPlayed = true;
                    }
                    else if (matchInfo.Player1HasPlayed == true && matchInfo.Player2Hasplayed == false)
                    {

                        matchInfo.Player2Id = Player.Id;
                        matchInfo.Player2Score = currentScore;
                        matchInfo.Player2Hasplayed = true;
                    }
                }
                db.SaveChanges();
            }
        }

    }
}