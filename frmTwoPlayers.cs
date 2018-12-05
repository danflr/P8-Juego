using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P8_JuegoLoco
{
    public partial class frmTwoPlayers : Form
    {

        Game game;
        Random rand;
        int steps;

        public frmTwoPlayers()
        {
            InitializeComponent();
        }

        private void frmTwoPlayers_Load(object sender, EventArgs e)
        {
            //game = Game.makeInstance(10, 2);
            game = new Game(10, 2);
            pbGrid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGrid.Image = ReDrawPicture();
            btnRightP1.Enabled = false;
            btnDownP1.Enabled = false;
            btnDownP2.Enabled = false;
            btnLeftP2.Enabled = false;
            btnRollP2.Enabled = false;
            rand = new Random();
            game.turn = 1;
            PrintMatrix();
            FillGrid();
            dgGrid.AllowUserToAddRows = false;
        }

        private Bitmap ReDrawPicture()
        {
            Bitmap image = new Bitmap(10, 10);
            SolidBrush brush = new SolidBrush(Color.Empty);
            using (Graphics g = Graphics.FromImage(image))
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        if (game.matrix[x, y].player == 0)
                        {
                            brush.Color = Color.FromKnownColor(KnownColor.White);
                            g.FillRectangle(brush, y, x, 1000000, 1000000);
                        }
                        else if (game.matrix[x, y].player == 1)
                        {
                            brush.Color = Color.FromKnownColor(KnownColor.Blue);
                            g.FillRectangle(brush, y, x, 1, 1);
                        }
                        else if (game.matrix[x, y].player == 2)
                        {
                            brush.Color = Color.FromKnownColor(KnownColor.Yellow);
                            g.FillRectangle(brush, y, x, 1, 1);
                        }
                        else if (game.matrix[x, y].player == 3)
                        {
                            brush.Color = Color.FromKnownColor(KnownColor.Red);
                            g.FillRectangle(brush, y, x, 1, 1);
                        }
                        else if (game.matrix[x, y].player == 4)
                        {
                            brush.Color = Color.FromKnownColor(KnownColor.Green);
                            g.FillRectangle(brush, y, x, 1, 1);
                        }
                    }
                }
            }
            PrintMatrix();
            return image;
            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            steps = rand.Next(1, 6);
            lblP1.Text = steps.ToString();
            btnRightP1.Enabled = true;
            btnDownP1.Enabled = true;
            btnRoll.Enabled = false;
        }

        private void btnRightP1_Click(object sender, EventArgs e)
        {
            if(game.FillField("r", steps))
            {
                ReDrawPicture();
                FillGrid();
                btnRightP1.Enabled = false;
                btnDownP1.Enabled = false;
                btnDownP2.Enabled = false;
                btnLeftP2.Enabled = false;
                btnRollP2.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                FillGrid();
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnRollP2_Click(object sender, EventArgs e)
        {
            steps = rand.Next(1, 6);
            btnDownP2.Enabled = true;
            btnLeftP2.Enabled = true;
            lblP2.Text = steps.ToString();
            btnRollP2.Enabled = false;
        }

        private void btnLeftP2_Click(object sender, EventArgs e)
        {
            if (game.FillField("l", steps))
            {
                ReDrawPicture();
                FillGrid();
                btnLeftP2.Enabled = false;
                btnDownP2.Enabled = false;
                btnDownP1.Enabled = false;
                btnRightP1.Enabled = false;
                btnRoll.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                FillGrid();
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnDownP1_Click(object sender, EventArgs e)
        {
            if(game.FillField("d", steps))
            {
                ReDrawPicture();
                FillGrid();
                btnRightP1.Enabled = false;
                btnDownP1.Enabled = false;
                btnDownP2.Enabled = false;
                btnLeftP2.Enabled = false;
                btnRollP2.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                FillGrid();
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnDownP2_Click(object sender, EventArgs e)
        {
            if(game.FillField("d", steps)){
                ReDrawPicture();
                FillGrid();
                btnLeftP2.Enabled = false;
                btnDownP2.Enabled = false;
                btnDownP1.Enabled = false;
                btnRightP1.Enabled = false;
                btnRoll.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            } else {
                FillGrid();
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void PrintMatrix()
        {
            Debug.Write("\n\n");
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Debug.Write(String.Format("[{0}]", game.matrix[i, j].player));
                }
                Debug.WriteLine("");
            }
            Debug.Write("\n\n");
        }

        private void FillGrid()
        {
            dgGrid.Rows.Clear();
            for(int  i = 0; i < 10; i++)
            {
                dgGrid.Rows.Add(game.matrix[i, 0].player.ToString(), game.matrix[i, 1].player.ToString(), game.matrix[i, 2].player.ToString(), game.matrix[i, 3].player.ToString(), game.matrix[i, 4].player.ToString(), game.matrix[i, 5].player.ToString(), game.matrix[i, 6].player.ToString(), game.matrix[i, 7].player.ToString(), game.matrix[i, 8].player.ToString(), game.matrix[i, 9].player.ToString());
                for(int j = 0; j < 10; j++)
                {
                    
                    if (game.matrix[i, j].player == 1) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    else if(game.matrix[i, j].player == 2) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    else if (game.matrix[i, j].player == 3) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else if (game.matrix[i, j].player == 4) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }
            }
        }

    }
}
