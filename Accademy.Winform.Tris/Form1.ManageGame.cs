using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Accademy.Winform.Tris
{
    public partial class Form1 : Form
    {
        private void initTris()
        {
            //non devo passargli la matrice perché la vede già
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        private new void Move(int player, int i, int j)
        { 
            //abbiamo messo il new perché c'è già un metodo Control.Move, quindi farebbe casino, così facendo ogni volta che chiamo move uso questo.
            matrix[i, j] = player;
        }
        private bool IsWinner(int player)
        {
            /* Se avessi passato String player_string e avessi dovuto trasformarlo in intero
             * potevo scrivere:
             * int player = player_string =="A" ? 1:2;
             * che è una sorta di if else scritto sulla stessa riga.
             */
            bool result = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == player)
                    {
                        result = RowControl(player, i);
                        if (result == true) break;
                        result = ColumnControl(player, j);
                        if (result == true) break;
                        if ((i + j) % 2 == 0) result = DiagonalControl(player, i, j);
                        if (result == true) break;
                    }
                }
                if (result == true) break;
            }
            return result;
        }

        private bool DiagonalControl(int v, int i, int j)
        {
            bool diagonal = false;
            bool antidiagonal = false;
            if (i == j)
            {
                diagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, k] == v) diagonal = diagonal && true;
                    else diagonal = diagonal && false;
                }
            }
            if (i + j == 2)
            {
                antidiagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, matrix.GetLength(0) - 1 - k] == v) antidiagonal = antidiagonal && true;
                    else antidiagonal = antidiagonal && false;
                }
            }

            return (diagonal || antidiagonal);
        }

        private bool ColumnControl(int v, int j)
        {
            bool isEqual = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }

        private bool RowControl(int v, int i)
        { //restituisce true se v è vincitore lungo la riga i

            bool isEqual = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }
        private void EndGame()
        {
            txt_00.Enabled = false;
            txt_01.Enabled = false;
            txt_02.Enabled = false;
            txt_10.Enabled = false;
            txt_11.Enabled = false;
            txt_12.Enabled = false;
            txt_20.Enabled = false;
            txt_21.Enabled = false;
            txt_22.Enabled = false;
        }

    }
}
