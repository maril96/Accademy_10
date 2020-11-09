using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class Printer
    {
        private MailManager mm;
        public Printer(MailManager mm)
        {
            this.mm = mm;
            this.mm.MailArrived += Mm_MailArrived;
            //questa è una facility sintattica che si può usare, il Delegate viene costruito automaticamente
            //avremmo potuto scrivere:
            //MailManagerEventHandler del = new MailManagerEventHandler(Mm_MailArrived);
            //this.mm.MailArrived += del;
        }

        private void Mm_MailArrived(object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a printer\r\n Mail from {0}\t\t Mail to {1} \r\n Subject: {2} \t\t Body: {3}", args.From, args.To, args.Subject, args.Body);
        }
    }
}
