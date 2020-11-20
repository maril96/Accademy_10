using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Negozio
    {
        public string Nome { get;}
        public string[] Proprietario { get;}
        public List<Prodotto> Lista_prodotti { get;}

        public Negozio(string nome, string nome_prop, string cognome_prop)
        {
            this.Proprietario = new string[2];
            this.Proprietario[0] = nome_prop;
            this.Proprietario[1] = cognome_prop;
            this.Nome = nome;
            this.Lista_prodotti = new List<Prodotto>();

        }
        public Negozio(string nome, string nome_prop, string cognome_prop, Prodotto item)
        {
            this.Proprietario = new string[2];
            this.Proprietario[0] = nome_prop;
            this.Proprietario[1] = cognome_prop;
            this.Nome = nome;
            this.Lista_prodotti = new List<Prodotto>();
            Lista_prodotti.Add(item);
        }
        public Negozio(string nome, string nome_prop, string cognome_prop, List<Prodotto> items)
        {
            this.Proprietario = new string[2];
            this.Proprietario[0] = nome_prop;
            this.Proprietario[1] = cognome_prop;
            this.Nome = nome;
            this.Lista_prodotti = new List<Prodotto>();
            foreach (var item in items)
            {
                Lista_prodotti.Add(item);
            }
        }

    }
}
