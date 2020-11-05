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

        private int[,] matrix = new int[3, 3];
        public Form1()
        {
            lastMove = Moves.NoMoveYet;
            InitializeComponent();
            initTris();
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
