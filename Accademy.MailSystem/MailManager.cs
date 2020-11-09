using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    //dichiaro il delegate, convenzionalmente il Delegate che conterrà l'indirizzo di un metodo che gestisce questo evento
    //ha un nome che termina con EventHandler
    //potrebbe essere comodo racchiudere gli argomenti in una classe
    public class MailEventArgs
    {
        public String From { get; set; }
        public String To { get; set; }
        public String Body { get; set; }
        public String Subject { get; set; }
    }
    //solitamente tra gli argomenti si mette un object che ha sollevato l'evento: in questo caso avrei potuto scrivere MailManager, infatti è lui che solleva l'evento,
    //poi invece in questo caso avremo Fax e Printer che hanno dei metodi da avviare nel momento in cui l'evento viene sollevato.
    public delegate void MailManagerEventHandler(Object sender, MailEventArgs args);
    //il delegate deve essere dichiarato nello stesso namespace della classe che solleva l'evento. Nella classe si dichiara un evento di tipo "del delegate".
    
    public class MailManager
    {
        //stiamo dichiarando che è arrivata la mail, quindi stiamo creando un evento. Sintatticamente viene definito come un delegate (di tipo MailManagerEventHandler), quindi
        //in .NET, un evento è una lista di Delegate, in questo caso di Delegate di tipo MailManagerEventHandler.
        //Sollevare un evento in questo caso vuol dire accorgersi del fatto che sia arrivata una mail, prendere questa lista di "puntatori ai metodi", scorrerla ed invocare i metodi (a cui punta ciascun delegate)

        public event MailManagerEventHandler MailArrived;
        public void SimulateMailArrived(string from, string to, string subject, string body)
        {
            MailEventArgs args = new MailEventArgs()
            {
                Body = body,
                From = from,
                Subject = subject,
                To = to
            };

            if (MailArrived != null)
            {
                //MailArrived è null se nessuno si è sottoscritto, però poi nel foreach vado a tirarmi fuori la lista di Delegate esplicitamente
                //tramite le apposite funzioni

                foreach (Delegate item in MailArrived.GetInvocationList().ToList())
                {   
                    //GetInvocationList() restituisce un'array di Delegates, che poi viene trasformato in una lista con il ToList()
                    //Questo array contiene tutti i subscribers
                    MailManagerEventHandler mm_eh = (MailManagerEventHandler)item;
                    //riesco ad invocare il metodo attraverso il suo puntatore. Castando al Delegate specifico riesco a vedere esattamente che segnatura deve avere mm_eh.
                    mm_eh(this, args); //il primo argomento è chi ha sollevato l'evento, che è proprio MailManager
                    //qui invoco di volta in volta il metodo incapsulato dentro al delegate
                }
                // Avremmo potuto scrivere solo: MailArrived(this, args);
            }
            //O avremmo potuto scrivere tutto l'if come: MailArrived?.Invoke(this,args);
        }
    }
}
