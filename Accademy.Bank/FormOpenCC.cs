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
    //vogliamo che la form di Login passi il parametro username alla form di apertura CC
    //poi magari generiamo random il numero di conto 
   
    public partial class FormOpenCC : Form
    {
        private IDataManager datamanager;
        private String CurrentUser;
        public FormOpenCC()
        {
            InitializeComponent();
        }
        public FormOpenCC(string username)
        {
            InitializeComponent();
            datamanager = new FileSystemDataManager();
            this.CurrentUser = username;
            this.lbl_cliente.Text = CurrentUser;
            string numConto = Accademy.Helper.RandomHelper.GetNumConto(10);
            this.lbl_numeroconto.Text = numConto;
        }


        private void FormOpenCC_Load(object sender, EventArgs e)
        {
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            string numconto = this.lbl_numeroconto.Text;
            string username = this.lbl_cliente.Text;
            string nome = this.txt_nome.Text;
            string cognome = this.txt_cognome.Text;
            string cf = this.txt_cf.Text;

            ContoCorrente newcc = new ContoCorrente(numconto);

            Cliente newclient = new Cliente()
            {
                Username = username,
                FirstName = nome,
                LastName = cognome,
                CF = cf,
                mioConto = newcc
                
            };
            
            //datamanager.CreateNewContoCorrente(newcc);
            DataOperationResult result=datamanager.CreateNewCliente(newclient);
            //le entity che vengono create, si salvano nei supporti dati tramite il DataManager
            //Il dialogo tra le parti avviene tramite entities che sono distaccate dal DataManager
            if (result.IsOk)
            {
                //FormLogin formlogin = (FormLogin)Tag;
                //formlogin.Close();
                FormManageCC manageform = new FormManageCC(numconto);
                manageform.Tag = this;
                manageform.Show();
                this.Hide();
            }
            else
            {
                this.lbl_error.Text = result.Message;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
            FormLogin loginform = (FormLogin)Tag;
            loginform.Close();
        }
    }
}
