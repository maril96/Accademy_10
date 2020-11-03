using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Persona : IComparable
    {
        //diamo delle proprietà. get e set indicheranno la possibilità di stabilire e modificare quei campi.
        protected String Nome;
        protected String Cognome;
        protected int Eta;

        public Ruolo Inquadramento;

        public String Indirizzo { get; set; }

        //inseriamo il costruttore: esso non ha valori di ritorno, ma restituisce l'indirizzo dell'istanza.
        public Persona()
        {
                
        }
        public Persona(string name, string surname)
        {
            Nome = name;
            Cognome = surname;
            Inquadramento = Ruolo.TerzoLivello;
        }
        //facendo così nome e cognome, che possono essere modificati solo dall'interno, si impostano una volta per tutte alla costruzione della nuova istanza.
        public Persona(string name, string surname, Ruolo r)
        {
            Nome = name;
            Cognome = surname;
            this.Inquadramento = r;
        }
        
        public void SetIndirizzo (string address)
        {
            Indirizzo = address;
        }

        public void SetEta(int x)
        {
            this.Eta = x;
        }
        public override string ToString()
        {
            string s = "Persona: " + Nome + "\t\t" + Cognome + "\r\n" + "Età: " + Eta + "\r\n" + "Indirizzo: " + Indirizzo;
            return s;
        }

        public override bool Equals(object obj)
        {
            Persona p = (Persona)obj; //faccio downcast, perchè l'argomento sopra dev'essere un object per poter fare override
            return (this.Nome == p.Nome && this.Cognome == p.Cognome);
             
        }

        public override int GetHashCode()
        {
            String s = this.Nome + this.Cognome;
            return s.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Persona p = (Persona)obj;
            return (int) this.Inquadramento - (int)p.Inquadramento;
        }
    }
}
/*Se uso private, quella proprietà/metodo non viene ereditato. Se uso protected, quelle proprietà vengono ereditate, quindi sono visibili dalle
 * classi figlie, ma non possono essere modificate dall'esterno, tantomeno visualizzate.*/