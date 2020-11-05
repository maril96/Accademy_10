using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Accademy.Winform.Tris
{
    public partial class Form1 : Form
    {
        private void txt_20_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_20_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_20_isCorrect = true;
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
                    txt_20_isCorrect = true;
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
        private void txt_20_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_20_isCorrect == true)
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
                            Move(2, 2, 0);
                            this.txt_20.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 2, 0);
                            this.txt_20.Enabled = false;
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
                            Move(1, 2, 0);
                            this.txt_20.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 2, 0);
                            this.txt_20.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }
        private void txt_21_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_21_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_21_isCorrect = true;
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
                    txt_21_isCorrect = true;
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
        private void txt_21_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_21_isCorrect == true)
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
                            Move(2, 2, 1);
                            this.txt_21.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 2, 1);
                            this.txt_21.Enabled = false;
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
                            Move(1, 2, 1);
                            this.txt_21.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 2, 1);
                            this.txt_21.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }

        private void txt_22_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_22_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_22_isCorrect = true;
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
                    txt_22_isCorrect = true;
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
        private void txt_22_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_22_isCorrect == true)
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
                            Move(2, 2, 2);
                            this.txt_22.Enabled = false;
                            if (IsWinner(2))  {this.lbl_win.Text ="B wins!"; EndGame();} //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            Move(1, 2, 2);
                            this.txt_22.Enabled = false;
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
                            Move(1, 2, 2);
                            this.txt_22.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            Move(2, 2, 2);
                            this.txt_22.Enabled = false;
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
