using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class ProdottoInOfferta : Prodotto
    {
        public DateTime data_inizio_offerta { get;}

        public DateTime data_fine_offerta { get; }
        public ProdottoInOfferta(int codice, string descrizione, double prezzo, double sconto, DateTime data_inizio, DateTime data_fine)
            :base(codice, descrizione, prezzo, sconto)
        {
            this.data_inizio_offerta = data_inizio;
            this.data_fine_offerta = data_fine;
        }
        //questo costruttore imposta tutto.

    }
}
