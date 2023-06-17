using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Candy_Crush
{
    public class CandyCrushBoard
    {
        private List<string> candies;
        private PictureBox[,] board;
        private int rows;
        private int columns;
        private int score;

        public CandyCrushBoard(int rows, int columns)
        {
            candies = new List<string> { "Blue", "Orange", "Green", "Yellow", "Red", "Purple" };
            board = new PictureBox[rows, columns];
            this.rows = rows;
            this.columns = columns;
            score = 0;
        }

        public void InitializeBoard(Control container)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    PictureBox tile = new PictureBox();
                    tile.Name = $"{r}-{c}";
                    tile.Image = GetRandomCandyImage();
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;
                    tile.DragEnter += DragEnter;
                    tile.DragDrop += DragDrop;

                    container.Controls.Add(tile);
                    board[r, c] = tile;
                }
            }
        }

        private Image GetRandomCandyImage()
        {
            string candyColor = GetRandomCandyColor();
            string imagePath = $"./images/{candyColor}.png";
            return Image.FromFile(imagePath);
        }

        private string GetRandomCandyColor()
        {
            return candies[new Random().Next(candies.Count)];
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DragDrop(object sender, DragEventArgs e)
        {
            PictureBox sourceTile = (PictureBox)e.Data.GetData(typeof(PictureBox));
            PictureBox targetTile = (PictureBox)sender;

            if (!IsValidMove(sourceTile, targetTile))
                return;

            SwapCandies(sourceTile, targetTile);
            if (!HasValidMove())
                SwapCandies(sourceTile, targetTile);
        }

        private bool IsValidMove(PictureBox sourceTile, PictureBox targetTile)
        {
            Point sourceCoords = GetTileCoordinates(sourceTile);
            Point targetCoords = GetTileCoordinates(targetTile);

            int rowDiff = Math.Abs(sourceCoords.X - targetCoords.X);
            int colDiff = Math.Abs(sourceCoords.Y - targetCoords.Y);

            return (rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1);
        }

        private void SwapCandies(PictureBox tile1, PictureBox tile2)
        {
            Image tempImage = tile1.Image;
            tile1.Image = tile2.Image;
            tile2.Image = tempImage;
        }

        private Point GetTileCoordinates(PictureBox tile)
        {
            string[] coordinates = tile.Name.Split('-');
            int row = int.Parse(coordinates[0]);
            int col = int.Parse(coordinates[1]);
            return new Point(row, col);
        }

        private bool HasValidMove()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    PictureBox currentTile = board[r, c];

                    if (IsValidHorizontalMove(currentTile) || IsValidVerticalMove(currentTile))
                        return true;
                }
            }

            return false;
        }

        private bool IsValidHorizontalMove(PictureBox tile)
        {
            Point coords = GetTileCoordinates(tile);
            int row = coords.X;
            int col = coords.Y;

            if (col < columns - 2)
            {
                PictureBox nextTile1 = board[row, col + 1];
                PictureBox nextTile2 = board[row, col + 2];

                if (AreCandiesSame(tile, nextTile1) && AreCandiesSame(tile, nextTile2))
                    return true;
            }

            return false;
        }

        private bool IsValidVerticalMove(PictureBox tile)
        {
            Point coords = GetTileCoordinates(tile);
            int row = coords.X;
            int col = coords.Y;

            if (row < rows - 2)
            {
                PictureBox nextTile1 = board[row + 1, col];
                PictureBox nextTile2 = board[row + 2, col];

                if (AreCandiesSame(tile, nextTile1) && AreCandiesSame(tile, nextTile2))
                    return true;
            }

            return false;
        }

        private bool AreCandiesSame(PictureBox tile1, PictureBox tile2)
        {
            string color1 = Path.GetFileNameWithoutExtension(tile1.ImageLocation);
            string color2 = Path.GetFileNameWithoutExtension(tile2.ImageLocation);

            return color1 == color2 && !color1.Contains("blank");
        }
    }
}
