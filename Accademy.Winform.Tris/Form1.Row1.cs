using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Accademy.Winform.Tris
{
    public partial class Form1 : Form
    {
        private void txt_10_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_10_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_10_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;

                }
            } //ne devo fare due perchè le condizioni sono mutuamente esclusive
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_10_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;
                }
            }
            else
            {
                this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                e.Handled = true;
                //l'ultimo vuol dire che non faccio più gestire a nessuno nessun evento, cioè l'evento KeyPress non viene attivato.

            }
            //controllo i casi in cui ho inserito lettere maiuscole O o X.
        }
        private void txt_10_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_10_isCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 'X')
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 0);
                            this.txt_10.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 0);
                            this.txt_10.Enabled = false;
                            if (IsWinner(1))  {this.lbl_win.Text ="A wins!"; EndGame();} //'X'
                        }
                        else
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:

                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 0);
                            this.txt_10.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 0);
                            this.txt_10.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }
        private void txt_11_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_11_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_11_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;

                }
            } //ne devo fare due perchè le condizioni sono mutuamente esclusive
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_11_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;
                }
            }
            else
            {
                this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                e.Handled = true;
                //l'ultimo vuol dire che non faccio più gestire a nessuno nessun evento, cioè l'evento KeyPress non viene attivato.

            }
            //controllo i casi in cui ho inserito lettere maiuscole O o X.
        }
        private void txt_11_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_11_isCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 'X')
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 1);
                            this.txt_11.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 1);
                            this.txt_11.Enabled = false;
                            if (IsWinner(1))  {this.lbl_win.Text ="A wins!"; EndGame();} //'X'
                        }
                        else
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:

                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 1);
                            this.txt_11.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 1);
                            this.txt_11.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }

        private void txt_12_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_12_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_12_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;

                }
            } //ne devo fare due perchè le condizioni sono mutuamente esclusive
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_12_isCorrect = true;
                }
                else
                {
                    this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    e.Handled = true;
                }
            }
            else
            {
                this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                e.Handled = true;
                //l'ultimo vuol dire che non faccio più gestire a nessuno nessun evento, cioè l'evento KeyPress non viene attivato.

            }
            //controllo i casi in cui ho inserito lettere maiuscole O o X.
        }
        private void txt_12_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_12_isCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 'X')
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 2);
                            this.txt_12.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 2);
                            this.txt_12.Enabled = false;
                            if (IsWinner(1))  {this.lbl_win.Text ="A wins!"; EndGame();} //'X'
                        }
                        else
                        {
                            this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:

                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 1, 2);
                            this.txt_12.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 1, 2);
                            this.txt_12.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }
    }
}
