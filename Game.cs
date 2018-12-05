using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_JuegoLoco
{

    class FieldData
    {
        public int player;
        public bool locked;

        public FieldData(int player, bool locked)
        {
            this.player = player;
            this.locked = locked;
        }

    }

    class Game
    {
        public int turn;
        public FieldData[,] matrix;
        public int[] players;
        public int playerAmount;
        private static Game instance;
        private bool done;

        public Game(int dim, int players)
        {
            this.turn = 1;
            this.matrix = new FieldData[dim, dim];
            this.playerAmount = players;
            this.players = new int[players + 1];
            this.done = false;
            InitGame();
        }

        public static Game makeInstance(int dim, int players)
        {
            if (instance == null) instance = new Game(dim, players);
            return instance;
        }

        public void InitGame()
        {
            Random rand = new Random();
            for(int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= matrix.GetUpperBound(0); j++)
                {
                    matrix[i, j] = new FieldData(0, false);
                    //int player = rand.Next(0, 4);
                    //matrix[i, j] = new FieldData(player, (player == 0) ? false : true);
                }
            }
            matrix[0, 0] = new FieldData(1, true);
            matrix[0, 9] = new FieldData(2, true);
            if(playerAmount >= 3) matrix[9, 0] = new FieldData(3, true);
            if(playerAmount == 4) matrix[9, 9] = new FieldData(4, true);
        }

        public int CalculateWinner()
        {
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(0); j++)
                {
                    players[matrix[i, j].player]++;
                }
            }
            int max = 0;
            int maxIndex = 0;
            for(int i = 1; i <= playerAmount; i++)
            {
                if(players[i] > max)
                {
                    max = players[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public bool IncreaseField(string direction, int amount)
        {
            int steps;
            bool endGame = false;
            switch (turn)
            {
                case 1:
                    steps = amount;
                    for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                    {
                        for(int j = 0; j <= matrix.GetUpperBound(0); j++)
                        {
                            if(direction == "d")
                            {
                                if (matrix[i, j].player == 1 && !matrix[i + 1, j].locked && steps > 0)
                                {
                                    matrix[i + 1, j] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                } else if(matrix[i, j].player == 1 && matrix[i + 1, j].locked && matrix[i + 1, j].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            } else if(direction == "r")
                            {
                                if (matrix[i, j].player == 1 && !matrix[i, j + 1].locked && steps > 0)
                                {
                                      matrix[i, j + 1] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 1 && matrix[i, j + 1].locked && matrix[i, j + 1].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                        }
                    }
                    break;

                case 2:
                    steps = amount;
                    for (int i = 0; i < matrix.GetUpperBound(0); i++)
                    {
                        for (int j = matrix.GetUpperBound(0); j > 0; j--)
                        {
                            if (direction == "d")
                            {
                                if (matrix[i, j].player == 2 && !matrix[i + 1, j].locked && steps > 0)
                                {
                                    matrix[i + 1, j] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 2 && matrix[i + 1, j].locked && matrix[i + 1, j].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                            else if (direction == "l")
                            {
                                if (matrix[i, j].player == 2 && !matrix[i, j - 1].locked && steps > 0)
                                {
                                    matrix[i, j - 1] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 2 && matrix[i, j - 1].locked && matrix[i, j - 1].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                        }
                    }
                    break;

                case 3:
                    steps = amount;
                    for (int i = matrix.GetUpperBound(0); i > 0; i--)
                    {
                        for (int j = 0; j < matrix.GetUpperBound(0); j++)
                        {
                            if (direction == "u")
                            {
                                if (matrix[i, j].player == 3 && !matrix[i - 1, j].locked && steps > 0)
                                {
                                    matrix[i - 1, j] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 3 && matrix[i - 1, j].locked && matrix[i - 1, j].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                            else if (direction == "r")
                            {
                                if (matrix[i, j].player == 3 && !matrix[i, j + 1].locked && steps > 0)
                                {
                                    matrix[i, j + 1] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 3 && matrix[i, j + 1].locked && matrix[i, j + 1].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                        }
                    }
                    break;

                case 4:
                    steps = amount;
                    for (int i = matrix.GetUpperBound(0); i > 0; i--)
                    {
                        for (int j = matrix.GetUpperBound(0); j > 0; j--)
                        {
                            if (direction == "u")
                            {
                                if (matrix[i, j].player == 4 && !matrix[i - 1, j].locked && steps > 0)
                                {
                                    matrix[i - 1, j] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 4 && matrix[i - 1, j].locked && matrix[i - 1, j].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                            else if (direction == "l")
                            {
                                if (matrix[i, j].player == 4 && !matrix[i, j - 1].locked && steps > 0)
                                {
                                    matrix[i, j - 1] = new FieldData(turn, true);
                                    steps--;
                                    PrintMatrix();
                                }
                                else if (matrix[i, j].player == 4 && matrix[i, j - 1].locked && matrix[i, j - 1].player != 1)
                                {
                                    //System.Windows.Forms.MessageBox.Show("El juego ha terminado, el ganador es {CalculateWinner()}", "Juego terminado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    endGame = true;
                                }
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
            return endGame;
        }

        public bool FillField(string dir, int amount)
        {
            int steps = amount;
            bool endGame = false;
            try
            {
                int i = 0;
                int j = 0;
                switch (turn)
                {
                    case 1:
                        i = 0;
                        j = 0;
                        if (dir == "r")
                        {        
                            while (matrix[i, 0].player == 1)
                            {
                                steps = amount; 
                                while (steps > 0)
                                {
                                    i = 0;
                                    if (matrix[i, j].player != 1 && !matrix[i, j].locked)
                                    {
                                        matrix[i, j] = new FieldData(1, true);
                                        steps--;
                                    }
                                    else if (matrix[i, j].player != 1 && matrix[i, j].locked)
                                    {
                                        return endGame;
                                    }
                                    j++;
                                }
                                i++;
                            }
                        } else if(dir == "d")
                        {
                            while (matrix[0, i].player == 1)
                            {
                                steps = amount;
                                j = 0;
                                while (steps > 0)
                                {
                                    if (matrix[j, i].player != 1 && !matrix[j, i].locked)
                                    {
                                        matrix[j, i] = new FieldData(1, true);
                                        steps--;
                                    }
                                    else if (matrix[j, i].player != 1 && matrix[j, i].locked)
                                    {
                                        return endGame;
                                    }
                                    j++;
                                }
                                i++;
                            }
                        }
                        break;
                    case 2:
                        if (dir == "l")
                        {
                            i = 0;
                            j = 9;
                            while (matrix[i, 9].player == 2)
                            {
                                steps = amount;
                                j = 9;
                                while (steps > 0)
                                {
                                    if (matrix[i, j].player != 2 && !matrix[i, j].locked)
                                    {
                                        matrix[i, j] = new FieldData(2, true);
                                        steps--;
                                    }
                                    else if (matrix[i, j].player != 2 && matrix[i, j].locked)
                                    {
                                        return endGame;
                                    }
                                    j--;
                                }
                                i++;
                            }
                        }
                        else if (dir == "d")
                        {
                            i = 9;
                            j = 0;
                            while (matrix[0, i].player == 2)
                            {
                                steps = amount;
                                j = 0;
                                while (steps > 0)
                                {
                                    if (matrix[j, i].player != 2 && !matrix[j, i].locked)
                                    {
                                        matrix[j, i] = new FieldData(2, true);
                                        steps--;
                                    }
                                    else if (matrix[j, i].player != 2 && matrix[j, i].locked)
                                    {
                                        return endGame;
                                    }
                                    j++;
                                }
                                i--;
                            }
                        }
                        break;
                    case 3:
                        i = 9;
                        j = 0;
                        if (dir == "r")
                        {
                            while (matrix[i, 0].player == 3)
                            {
                                steps = amount;
                                j = 0;
                                while (steps > 0)
                                {
                                    if (matrix[i, j].player != 3 && !matrix[i, j].locked)
                                    {
                                        matrix[i, j] = new FieldData(3, true);
                                        steps--;
                                    }
                                    else if (matrix[i, j].player != 3 && matrix[i, j].locked)
                                    {
                                        return endGame;
                                    }
                                    j++;
                                }
                                i--;
                            }
                        }
                        else if (dir == "u")
                        {
                            i = 0;
                            while (matrix[9, i].player == 3)
                            {
                                steps = amount;
                                j = 9;
                                while (steps > 0)
                                {
                                    if (matrix[j, i].player != 3 && !matrix[j, i].locked)
                                    {
                                        matrix[j, i] = new FieldData(3, true);
                                        steps--;
                                    }
                                    else if (matrix[j, i].player != 3 && matrix[j, i].locked)
                                    {
                                        return endGame;
                                    }
                                    j--;
                                }
                                i++;
                            }
                        }
                        break;
                    case 4:
                        i = 9;
                        j = 9;
                        if (dir == "l")
                        {
                            while (matrix[i, 9].player == 4)
                            {
                                steps = amount;
                                j = 9;
                                while (steps > 0)
                                {
                                    if (matrix[i, j].player != 4 && !matrix[i, j].locked)
                                    {
                                        matrix[i, j] = new FieldData(4, true);
                                        steps--;
                                    }
                                    else if (matrix[i, j].player != 4 && matrix[i, j].locked)
                                    {
                                        return endGame;
                                    }
                                    j--;
                                }
                                i--;
                            }
                        }
                        else if (dir == "u")
                        {
                            i = 9;
                            while (matrix[9, i].player == 4)
                            {
                                steps = amount;
                                j = 9;
                                while (steps > 0)
                                {
                                    if (matrix[j, i].player != 4 && !matrix[j, i].locked)
                                    {
                                        matrix[j, i] = new FieldData(4, true);
                                        steps--;
                                    }
                                    else if (matrix[j, i].player != 4 && matrix[j, i].locked)
                                    {
                                        return endGame;
                                    }
                                    j--;
                                }
                                i--;
                            }
                        }
                        break;
                    default: break;
                }
            }catch(Exception ex)
            {
                Debug.Write("\n" + ex.Message + "\n");
            }
            return true;
        }

        public void ChangeTurn()
        {
            if (turn + 1 <= playerAmount) turn++;
            else turn = 1;
        }

        private void PrintMatrix()
        {
            Debug.Write("\n\n");
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Debug.Write(String.Format("[{0}]", matrix[i, j].player));
                }
                Debug.WriteLine("");
            }
            Debug.Write("\n\n");
        }

    }
}
