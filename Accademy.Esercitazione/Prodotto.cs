using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Prodotto
    {
        public int codice { get; }
        public string descrizione { get; }
        public double prezzo { get; }
        public double sconto { get; }
        
        public Prodotto(int codice, string descrizione, double prezzo, double sconto)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.sconto = sconto;
        }
        public Prodotto(string descrizione, double prezzo, double sconto)
        {
            this.codice = -1;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.sconto = sconto;
        }
        public Prodotto(int codice, string descrizione)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.prezzo = 0;
            this.sconto = 0;
        }
        public Prodotto(string descrizione)
        {
            this.descrizione = descrizione;
            this.codice = -1;
            this.prezzo = 0;
            this.sconto = 0;

        }
    }
}
