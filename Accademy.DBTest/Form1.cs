using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienti_Click(object sender, EventArgs e)
        {
            //chiaramente dovrebbe essere un'altra classe a gestire il DataBase...ora la apriamo nei comandi del bottone per semplicità

            string connectionString = @"Data Source=WINAPUXGGIRX7PJ\SQLEXPRESS;Initial Catalog=AccademyDB;Integrated Security=True";
            //si trova selezionando il db su server explorer e cercando nelle properties la ConnectionString
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlcmdText = "SELECT TOP (1000) [ID] ,[FirstName] ,[LastName] ,[FiscalCode] FROM[AccademyDB].[dbo].[Clients]";
                SqlCommand cmd = new SqlCommand(sqlcmdText, con);

                con.Open();
                //apro la connessione che ho creato
                SqlDataReader dr = cmd.ExecuteReader();
                //come quando facevo lo streamReader: mi posiziono in cima ai record, poi li scorro
                //ExecuteReader si aspetta come risultato un SQLDataReader, ExecuteScalar restituisce un Object
                //ad esempio se faccio un SELECT mi aspetto dei record, quindi un SQLDataReader, se faccio COUNT mi aspetto un intero, quindi un Object
                while (dr.Read() != false)
                {
                    //quando Read mi restituisce false vuol dire che ho finito i record
                    string id = dr[0].ToString();
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();

                    string item =id +" "+ firstName + " " + lastName;
                    this.lst_Clienti.Items.Add(item);
                }
                con.Close(); 
                //facciamo la Dispose con using, in modo che se la Close non andasse a buon fine
                //saremmo comunque sicuri che la connessione verrà tagliata
            }

        }

        private void lst_Clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //voglio che quando seleziono un nome mi dia la lista dei suoi cc nell'altra listbox
            string item = this.lst_Clienti.SelectedItem.ToString();
            char sep = ' ';
            string[] campi =item.Split(sep);
            int ID = Int32.Parse(campi[0]);
           //ora dobbiamo riprenderci il comando che lega questo ID all'Owner del CC.
        }
    }
}
