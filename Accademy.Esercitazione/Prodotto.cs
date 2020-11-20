using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Prodotto
    {
        public int Codice { get; }
        public string Descrizione { get; }
        public double Prezzo { get; }
        public double Sconto { get; }
        
        public Prodotto(int codice, string descrizione, double prezzo, double sconto)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto;
        }
        public Prodotto(string descrizione, double prezzo, double sconto)
        {
            this.Codice = -1;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto;
        }
        public Prodotto(int codice, string descrizione)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;
        }
        public Prodotto(string descrizione)
        {
            this.Descrizione = descrizione;
            this.Codice = -1;
            this.Prezzo = 0;
            this.Sconto = 0;

        }
    }
}
