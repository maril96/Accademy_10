using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public interface IPrintLetter
    {
        void StampaLettera(string testo);
        //al momento l'interfaccia contiene una sola firma di metodo (non si mette di nuovo il public davanti alle firme)

        
    }
}
