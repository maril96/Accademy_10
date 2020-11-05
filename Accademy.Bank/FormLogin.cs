using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Bank
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {   //chiudo una form e ne apro un'altra
            if(this.txt_username.Text == "A")
            {
                FormOpenCC openform = new FormOpenCC();
                openform.Tag = this;
                openform.Show();
                this.Hide();
                //così apro l'altra form e chiudo la mia.
            }
            else
            {
                FormManageCC manageform = new FormManageCC();
                manageform.Show();
                this.Hide();
            }
            //forse sarebbe meglio modificare ad un certo punto la form corrente
        }
    }
}
