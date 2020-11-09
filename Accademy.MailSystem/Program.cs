using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();

            Fax fax = new Fax(mm);
            Printer prn = new Printer(mm);
            //abbiamo creato un MailManager e passato la stessa istanza ai costruttori di Fax e Print, che quindi
            //appiccicheranno i loro Delegate all'evento della stessa istanza mm.
            //così una volta sollevato l'evento di mm, si andranno ad eseguire i metodi di tutti i subscriber.

            mm.SimulateMailArrived("Agata","Maurizio","Call","Fissiamo la chiamata per mercoledì alle 11");
            mm.SimulateMailArrived("Guglielmo", "Maurizio", "Calcetto", "Stasera alle 18 partitella");
        }
    }
}
