using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{//Impiegato eredita da Persona ed implementa IPrintLetter
    public class Impiegato : Persona, IPrintLetter
    {
        //vorrei che l'impiegato avesse anche le proprietà di Persona, cioè nome, cognome ed età, e poi abbia delle proprie caratteristiche.
        //Si usa l'ereditarietà: si fa una classe base che poi viene ereditata da tutte le altre che voglio abbiano quelle caratteristiche
        // scrivendo " class Impiegato : Persona ", tutte le proprietà, i metodi e i costruttori di Persona vengono ereditati da impiegato.
        //la catena di ereditarietà può prolungarsi, ma in genere dopo 3 o 4 si evita.
       //ovviamente le proprietà ereditate sono quelle "ereditabili", quindi quelle private non si ereditano.
        
        public String Matricola { get; set; }

        public Impiegato(string nome, string cognome, int eta)
            :base(nome, cognome)
        {
            //la riga sopra: il costruttore invoca quello della classe base, ma deve sapere cosa passare a quest'ultimo.
            Eta = eta;
        }

        public void StampaLettera(string testo)
        {
            //si trasforma il testo in minuscolo
            string txt = testo.ToLower();
            //si stampa
            System.Console.WriteLine(txt);
        }
    }
}
//quando creo una classe, per poterla poi utilizzare (e istanziare), devo mettere l'aggettivo 'public'