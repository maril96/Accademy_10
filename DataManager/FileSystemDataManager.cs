using Accademy.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class FileSystemDataManager : IDataManager
    {
        private string bankDir = @"C:\Users\marilena.pandolfi\Documents\Microsoft Accademy";
        private string usersFileName;
        private string clientiFileName;
        private string ccFileName;
        private string movimentiFileName;
        
        public FileSystemDataManager()
        {
            usersFileName = System.IO.Path.Combine(bankDir, "Users.txt");
            clientiFileName = System.IO.Path.Combine(bankDir, "Clienti.txt");
            ccFileName = System.IO.Path.Combine(bankDir, "Conticorrenti.txt");
            movimentiFileName = System.IO.Path.Combine(bankDir, "Movimenti.txt");
        }
        public DataOperationResult CreateNewCliente(Cliente newclient)
        {
            DataOperationResult result = new DataOperationResult();
            try
            {
               
                using(System.IO.StreamWriter sw_clienti = File.AppendText(clientiFileName))
                {
                    //con lo using stiamo facendo una Dispose, cioè gli diciamo di rilasciare tutte le risorse non gestite.
                    //così sicuramente dopo la Close si interromperà lo stream di byte.
                    string new_cliente = newclient.Username + ";" + newclient.FirstName + ";" + newclient.LastName + ";" + newclient.CF;
                    sw_clienti.WriteLine(new_cliente);
                    sw_clienti.Close();
                }
                using (System.IO.StreamWriter sw_cc = File.AppendText(ccFileName))
                {
                    ContoCorrente new_cc = newclient.mioConto;
                    string s_new_cc = new_cc.GetNumeroConto() + ";" + new_cc.GetSaldo() + ";" + newclient.Username;
                    sw_cc.WriteLine(s_new_cc);
                    sw_cc.Close(); 
                }
                result.IsOk = true;
            }
            catch (Exception excp)
            {
                result.IsOk = false;
                result.Message = excp.Message;
                
            }

            return result;
        }
        public bool LoginIsOk(string username, string password)
        {
            //Salvare un file di testo (da qualche parte) "Users.txt", in cui inserire gli utenti nel seguente modo:
            // per ogni utente c'è una riga "username; password"
            //questa funzione deve leggere questo file e verificare che in corrispondenza dello user ci sia la password
            bool isOk = false;
            
            System.IO.StreamReader file = new System.IO.StreamReader(usersFileName);
            string line;
            char separatore = ';';
           
            
            while((line = file.ReadLine()) != null)
            {
                String[] userData = line.Split(separatore);
                if (userData[0] == username && userData[1] == password)
                {
                    isOk = true;
                    break;
                }
            }
            file.Close();
            return isOk;
        }
        public bool ThereIsCC(string username)
        {
            bool thereis = false;
            System.IO.StreamReader file = new System.IO.StreamReader(ccFileName);
            string line;
            char separatore = ';';


            while (!String.IsNullOrEmpty(line = file.ReadLine()))
            { 
                String[] userData = line.Split(separatore);
                if (userData[2] == username)
                {
                    thereis = true;
                    break;
                }
            }
            file.Close();
            return thereis;
        }

        ContoCorrente IDataManager.GetContoCorrenteByUsername(string username)
        {
            ContoCorrente cc_result = null;

            using (System.IO.StreamReader file = new System.IO.StreamReader(ccFileName))
            {
                string line;
                char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
                chararray[0] = ';';
                while (!String.IsNullOrEmpty(line = file.ReadLine())) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
                {
                    String[] resultArray = line.Split(chararray);
                    string current_user = resultArray[2];
                    if (username == current_user)
                    {
                        cc_result = new ContoCorrente(resultArray[0]);
                        break;
                    }
                }
                file.Close();
            }

            return cc_result;
        }
    }
}
