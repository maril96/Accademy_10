using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.Tris
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

        private void txt_00_TextChanged(object sender, EventArgs e)
        {
            //ciò che scriviamo qui accade nel momento in cui si scrive qualcosa nella txt_00

            switch (lastMove)
            {
                case Moves.X:
                    if (this.txt_00.Text == "X")
                    {
                        //se mi andasse bene anche il minuscolo potrei fare
                        // if(this.txt_00.Text.ToUpper()=="X"){this.txt_00.Text=this.txt_00.Text.ToUpper(); ...}
                        this.txt_00.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                    }
                    else if (this.txt_00.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_00.Enabled = false;
                    }
                    else
                    {
                        this.txt_00.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.O:
                    if (this.txt_00.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_00.Enabled = false;
                    }
                    else if (this.txt_00.Text == "O")
                    {
                        this.txt_00.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                    }
                    else
                    {
                        this.txt_00.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.NoMoveYet:

                    if (this.txt_00.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_00.Enabled = false;
                    }
                    else if (this.txt_00.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_00.Enabled = false;
                    }
                    else
                    {
                        this.txt_00.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                default:
                    break;
            }


        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {
            switch (lastMove)
            {
                case Moves.X:
                    if (this.txt_01.Text == "X")
                    {
                        //se mi andasse bene anche il minuscolo potrei fare
                        // if(this.txt_00.Text.ToUpper()=="X"){this.txt_00.Text=this.txt_00.Text.ToUpper(); ...}
                        this.txt_01.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                    }
                    else if (this.txt_01.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_01.Enabled = false;
                    }
                    else
                    {
                        this.txt_01.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.O:
                    if (this.txt_01.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_01.Enabled = false;
                    }
                    else if (this.txt_01.Text == "O")
                    {
                        this.txt_01.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                    }
                    else
                    {
                        this.txt_01.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.NoMoveYet:

                    if (this.txt_01.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_01.Enabled = false;
                    }
                    else if (this.txt_01.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_01.Enabled = false;
                    }
                    else
                    {
                        this.txt_01.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                default:
                    break;
            }
        }

        private void txt_02_TextChanged(object sender, EventArgs e)
        {
            switch (lastMove)
            {
                case Moves.X:
                    if (this.txt_02.Text == "X")
                    {
                        this.txt_02.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                    }
                    else if (this.txt_02.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_02.Enabled = false;
                    }
                    else
                    {
                        this.txt_02.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.O:
                    if (this.txt_02.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_02.Enabled = false;
                    }
                    else if (this.txt_02.Text == "O")
                    {
                        this.txt_02.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                    }
                    else
                    {
                        this.txt_02.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.NoMoveYet:

                    if (this.txt_02.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_02.Enabled = false;
                    }
                    else if (this.txt_02.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_02.Enabled = false;
                    }
                    else
                    {
                        this.txt_02.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                default:
                    break;
            }
        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        {
            switch (lastMove)
            {
                case Moves.X:
                    if (this.txt_10.Text == "X")
                    {
                        this.txt_10.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'O'!";
                    }
                    else if (this.txt_10.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_10.Enabled = false;
                    }
                    else
                    {
                        this.txt_10.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.O:
                    if (this.txt_10.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_10.Enabled = false;
                    }
                    else if (this.txt_10.Text == "O")
                    {
                        this.txt_10.Text = "";
                        this.lbl_error.Text = "L'unico valore possibile è 'X'!";
                    }
                    else
                    {
                        this.txt_10.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                case Moves.NoMoveYet:

                    if (this.txt_10.Text == "X")
                    {
                        lastMove = Moves.X;
                        this.txt_10.Enabled = false;
                    }
                    else if (this.txt_10.Text == "O")
                    {
                        lastMove = Moves.O;
                        this.txt_10.Enabled = false;
                    }
                    else
                    {
                        this.txt_10.Text = "";
                        this.lbl_error.Text = "I valori possibili sono 'X' e 'O'!";
                    }
                    break;
                default:
                    break;
            }
        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {
            this.txt_11.Enabled = false;
        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {
            this.txt_12.Enabled = false;
        }

        private void txt_20_TextChanged(object sender, EventArgs e)
        {
            this.txt_20.Enabled = false;
        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {
            this.txt_21.Enabled = false;
        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {
            this.txt_22.Enabled = false;
        }
    }
}