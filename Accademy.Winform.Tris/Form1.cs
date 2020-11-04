using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Winform.Tris
{

    public partial class Form1 : Form
    {
        private Moves lastMove;
        //questa è solo la dichiarazione della proprietà, poi inizializzo nel costruttore
        public Form1()
        {
            lastMove = Moves.NoMoveYet;
            InitializeComponent();
        }

        private bool txt_00_isCorrect = false;
        private bool txt_01_isCorrect = false;
        private bool txt_02_isCorrect = false;
        private bool txt_10_isCorrect = false;
        private bool txt_11_isCorrect = false;
        private bool txt_12_isCorrect = false;
        private bool txt_20_isCorrect = false;
        private bool txt_21_isCorrect = false;
        private bool txt_22_isCorrect = false;
        private void txt_00_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            txt_00_isCorrect = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if(e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_00_isCorrect = true;
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
                    txt_00_isCorrect = true;
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
        private void txt_00_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txt_00_isCorrect == true)
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
                            this.txt_00.Enabled = false;
                            IsWinner("B"); //'O'
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 'X')
                        {
                            lastMove = Moves.X;
                            this.txt_00.Enabled = false;
                            IsWinner("A"); //'X'
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
                            this.txt_00.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_00.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            else e.Handled = true;
        }

        private void IsWinner(string player)
        {
            if(player == "A")
            {

            }
            else
            {

            }
        }

        #region textchanged
        private void txt_00_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_02_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        { 
        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_20_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
