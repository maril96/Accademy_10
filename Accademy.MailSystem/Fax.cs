using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class Fax
    {
        private MailManager mm;
        
        public Fax(MailManager mm)
        {
            //qui gli passo un'istanza di MailManager, che sarà la stessa che passerò sia a Fax che a Printer.
            this.mm = mm;
            //questo sarebbe l'"InitializeComponents" della Form
            //Così il Fax ha un riferimento a MailManager; poi si costruisce il metodo proprio di Fax,
            //e lo si mette dentro ad un delegate, il quale viene accodato alla lista dei Delegate dell'evento MailArrived di MailManager
            //tramite il += (che invoca Add_MailArrived, metodo generato dall'evento per aggiungere Delegate alla lista).
            MailManagerEventHandler del = new MailManagerEventHandler(mm_MailArrived);
            this.mm.MailArrived += del;
        }
        public void mm_MailArrived(Object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a fax\r\n Mail from {0}\t\t Mail to {1} \r\n Subject: {2} \t\t Body: {3}", args.From, args.To, args.Subject, args.Body);

        }
    }
}
