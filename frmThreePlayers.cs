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
    public partial class frmThreePlayers : Form
    {

        Game game;
        Random rand;
        int steps;

        public frmThreePlayers()
        {
            InitializeComponent();
        }

        private void frmThreePlayers_Load(object sender, EventArgs e)
        {
            game = new Game(10, 4);
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
            btnUp3.Enabled = false;
            btnRight3.Enabled = false;
            btnLeft4.Enabled = false;
            btnUp4.Enabled = false;
            btnRoll3.Enabled = false;
            btnRoll4.Enabled = false;
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
            if (game.FillField("r", steps))
            {
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
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnDownP1_Click(object sender, EventArgs e)
        {
            if (game.FillField("d", steps))
            {
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
                FillGrid();
                btnLeftP2.Enabled = false;
                btnDownP2.Enabled = false;
                btnUp3.Enabled = false;
                btnRight3.Enabled = false;
                btnRoll3.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnDownP2_Click(object sender, EventArgs e)
        {
            if (game.FillField("d", steps))
            {
                FillGrid();
                btnLeftP2.Enabled = false;
                btnDownP2.Enabled = false;
                btnUp3.Enabled = false;
                btnRight3.Enabled = false;
                btnRoll3.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
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
            for (int i = 0; i < 10; i++)
            {
                dgGrid.Rows.Add(game.matrix[i, 0].player.ToString(), game.matrix[i, 1].player.ToString(), game.matrix[i, 2].player.ToString(), game.matrix[i, 3].player.ToString(), game.matrix[i, 4].player.ToString(), game.matrix[i, 5].player.ToString(), game.matrix[i, 6].player.ToString(), game.matrix[i, 7].player.ToString(), game.matrix[i, 8].player.ToString(), game.matrix[i, 9].player.ToString());
                for (int j = 0; j < 10; j++)
                {

                    if (game.matrix[i, j].player == 1) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    else if (game.matrix[i, j].player == 2) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    else if (game.matrix[i, j].player == 3) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else if (game.matrix[i, j].player == 4) dgGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void btnRoll3_Click(object sender, EventArgs e)
        {
            steps = rand.Next(1, 6);
            btnUp3.Enabled = true;
            btnRight3.Enabled = true;
            lblP3.Text = steps.ToString();
            btnRoll3.Enabled = false;
        }

        private void btnRight3_Click(object sender, EventArgs e)
        {
            if (game.FillField("r", steps))
            {
                FillGrid();
                btnUp4.Enabled = false;
                btnLeft4.Enabled = false;
                btnRight3.Enabled = false;
                btnUp3.Enabled = false;
                btnRoll4.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnUp3_Click(object sender, EventArgs e)
        {
            if (game.FillField("u", steps))
            {
                FillGrid();
                btnUp4.Enabled = false;
                btnLeft4.Enabled = false;
                btnRight3.Enabled = false;
                btnUp3.Enabled = false;
                btnRoll4.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnRoll4_Click(object sender, EventArgs e)
        {
            steps = rand.Next(1, 6);
            btnUp4.Enabled = true;
            btnLeft4.Enabled = true;
            lblP4.Text = steps.ToString();
            btnRoll4.Enabled = false;
        }

        private void btnLeft4_Click(object sender, EventArgs e)
        {
            if (game.FillField("l", steps))
            {
                FillGrid();
                btnUp4.Enabled = false;
                btnLeft4.Enabled = false;
                btnRight3.Enabled = false;
                btnUp3.Enabled = false;
                btnRoll.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnUp4_Click(object sender, EventArgs e)
        {
            if (game.FillField("u", steps))
            {
                FillGrid();
                btnUp4.Enabled = false;
                btnLeft4.Enabled = false;
                btnRight3.Enabled = false;
                btnUp3.Enabled = false;
                btnRoll.Enabled = true;
                game.ChangeTurn();
                PrintMatrix();
            }
            else
            {
                MessageBox.Show("El ganador es " + game.CalculateWinner() + ".", "Juego terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
