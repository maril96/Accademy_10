using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Negozio
    {
        public string nome { get;}
        public string[] proprietario { get;}
        public List<Prodotto> lista_prodotti { get;}

        public Negozio(string nome, string nome_prop, string cognome_prop)
        {
            this.proprietario = new string[2];
            this.proprietario[0] = nome_prop;
            this.proprietario[1] = cognome_prop;
            this.nome = nome;
            this.lista_prodotti = null;

        }
        public Negozio(string nome, string nome_prop, string cognome_prop, Prodotto item)
        {
            this.proprietario = new string[2];
            this.proprietario[0] = nome_prop;
            this.proprietario[1] = cognome_prop;
            this.nome = nome;
            this.lista_prodotti = new List<Prodotto>();
            lista_prodotti.Add(item);
        }
        public Negozio(string nome, string nome_prop, string cognome_prop, List<Prodotto> items)
        {
            this.proprietario = new string[2];
            this.proprietario[0] = nome_prop;
            this.proprietario[1] = cognome_prop;
            this.nome = nome;
            this.lista_prodotti = new List<Prodotto>();
            foreach (var item in items)
            {
                lista_prodotti.Add(item);
            }
        }

    }
}
