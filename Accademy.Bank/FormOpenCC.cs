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
    public partial class FormOpenCC : Form
    {
        public FormOpenCC()
        {
            InitializeComponent();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            FormManageCC manageform = new FormManageCC();
            manageform.Show();
            this.Close();
           /* this.Close();
            FormLogin loginform = (FormLogin)Tag;
            loginform.Close();
            //così chiudo anche la form di login che mi aveva fatto aprire questa, e che avevo nascosto
            //se rimane nascosta il programma non termina.
        Questa parte è il corpo di un bottone di chiusura
            */
         }

  
    }
}
