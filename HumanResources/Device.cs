using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Device : IPrintLetter
    {
        //faccio in modo che il Device possa implementare un'interfaccia

        public void StampaLettera(string testo)
        {
            //si trasforma il testo in maiuscolo
            string txt = testo.ToUpper();
            //si stampa
            System.Console.WriteLine(txt);
            //Device stampa il testo in Upper, Impiegato lo stampa in Lower.
            //Il comportamento dell'impiegato e del Device è uguale per questo aspetto: 
            //entrambi stampano del testo, ma ognuno lo fa in modo diverso.
            //Si parla di polimorfismo per la funzione StampaLettera.
        }

    }
}
