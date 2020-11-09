using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.TestDelegate
{
    public class MyClass
    {
        private Button externalButton;
        public MyClass(Button button)
        {
            this.externalButton = button;
            this.externalButton.Click += new System.EventHandler(this.externalButton_Click);
            //nel costruttore di MyClass, si prende la lista di Delegate (l'evento) del Click e vi si aggiunge il riferimento alla nostra funzione.
            //Alla fine quando si clickerà sul bottone di riferimento, tra le altre cose, si eseguirà questo metodo, mostrando il MessageBox.
        }

        private void externalButton_Click(object sender, EventArgs e)
        {
            //i parametri poi gli vengono passati da chi ha sollevato l'evento, e sono propri in questo caso del bottone.
            MessageBox.Show("Click handled by MyClass instance");
            //con MessageBox si apre un popup che mostra questo messaggio.
        }
    }
}
