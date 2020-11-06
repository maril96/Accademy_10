using Accademy.Entities;
using DataManager;
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
        private IDataManager datamanager;
        public FormLogin()
        {
            datamanager = new FileSystemDataManager();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {   //chiudo una form e ne apro un'altra

            //bisogna controllare se l'username è 'registrato' e che username e password sono corretti.
            //qui siamo su un'interfaccia grafica, quindi non è competenza di questo codice decidere se username e pw sono corretti.
            //per verificare le credenziali dovrò leggere su un qualche supporto


            //qui: se le credenziali sono corrette indirizzo nella form successiva,
            //altrimenti plotto qualcosa nella label login_error

            string username = this.txt_username.Text;
            string password = this.txt_password.Text;

            if (datamanager.LoginIsOk(username, password))
            {
                if (!datamanager.ThereIsCC(username))
                {
                    FormOpenCC openform = new FormOpenCC(username);
                    openform.Tag = this;
                    openform.Show();
                    this.Hide();
                    //così apro l'altra form e chiudo la mia.
                }
                else
                {
                    ContoCorrente cc =datamanager.GetContoCorrenteByUsername(username);
                    FormManageCC manageform = new FormManageCC(cc.GetNumeroConto());
                    manageform.Tag = this;
                    manageform.Show();
                    this.Hide();
                }
            }
            else this.login_error.Text = "Non sei registrato!";
        }
    }
}
