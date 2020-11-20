using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
           // Test_CreazioneProdotto();
           // Test_CreazioneNegozio();
            Test_Offerte();

            /*cosa avrei dovuto fare: creare prima il negozio e poi aggiungerci una lista di prodotti, quindi
             * creare una funzione che aggiunge al negozio una lista di prodotti a posteriori.
             * Nella lista possono essere presenti sia Prodotto che ProdottoInOfferta: andrebbe verificato di che tipo sono
             * facendo un GetType */
        }

        private static void Test_Offerte()
        {
            List<ProdottoInOfferta> prodotti = new List<ProdottoInOfferta>();
            for (int i = 0; i < 4; i++)
            {
                prodotti.Add(GetProdotto());
            }

            Negozio myNegozio = GetNegozio(prodotti);

            List<ProdottoInOfferta> offerte = new List<ProdottoInOfferta>();
            ProdottoInOfferta product;
            foreach (var item in myNegozio.Lista_prodotti)
            {
                 product = (ProdottoInOfferta)item;
                 if(isInOfferta(product))
                    {
                        offerte.Add(product);
                    }
            }
            Console.WriteLine("Offerte di oggi al negozio {0}:", myNegozio.Nome);
            foreach (var item in offerte)
            {
                Console.WriteLine("{0}: prezzo {1} euro e sconto del {2}%", item.Descrizione, item.Prezzo.ToString(), item.Sconto.ToString());
            }
        }

        private static bool isInOfferta(ProdottoInOfferta product)
        {
            bool result = false;
            if (product.Data_inizio_offerta < DateTime.Now && product.Data_fine_offerta.AddDays(1) > DateTime.Now) result = true;
            return result;
        }

        private static Negozio GetNegozio(List<ProdottoInOfferta> prodotti)
        {
            Console.WriteLine("Inserire Nome Negozio:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserire Nome Proprietario:");
            string nome_prop = Console.ReadLine();
            Console.WriteLine("Inserire Cognome Proprietario:");
            string cognome_prop = Console.ReadLine();

            List<Prodotto> lista_prodotti = new List<Prodotto>();
            foreach (var item in prodotti)
            {
                lista_prodotti.Add((Prodotto)item);
            }
            return new Negozio(nome, nome_prop, cognome_prop, lista_prodotti);
        }

        private static ProdottoInOfferta GetProdotto()
        {
            Console.WriteLine("Inserire Codice Prodotto:");
            int codice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Descrizione Prodotto:");
            string descrizione = Console.ReadLine();
            Console.WriteLine("Inserire Prezzo Prodotto:");
            double prezzo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Sconto Prodotto:");
            double sconto = Double.Parse(Console.ReadLine());

            Console.WriteLine("Inserire Data Inizio Sconto:");
            DateTime data_inizio = new DateTime(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Inserire Data Fine Sconto:");
            DateTime data_fine = new DateTime(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));


            return new ProdottoInOfferta(codice, descrizione,prezzo, sconto,data_inizio, data_fine);
        }

        private static void Test_CreazioneNegozio()
        {
            Console.WriteLine("Test primo costruttore.");
            Console.WriteLine("Inserire Nome Negozio:");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Inserire Nome Proprietario:");
            string nome_prop1 = Console.ReadLine();
            Console.WriteLine("Inserire Cognome Proprietario:");
            string cognome_prop1 = Console.ReadLine();
            
            Negozio negozio1 = new Negozio(nome1, nome_prop1, cognome_prop1);
            Console.WriteLine("Ho creato il negozio {0}, il cui proprietario è {1} {2}.", negozio1.Nome, negozio1.Proprietario[0], negozio1.Proprietario[1]);
            if(negozio1.Lista_prodotti==null) Console.WriteLine("Nel negozio non sono presenti prodotti.");
            else
            {
                Console.WriteLine("Nel negozio sono presenti i seguenti prodotti: ");
                foreach (var prod in negozio1.Lista_prodotti)
                {
                    Console.WriteLine("{0}", prod.Descrizione);
                }
            }

            Console.WriteLine("Test secondo costruttore.");
            Console.WriteLine("Inserire Nome Negozio:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Inserire Nome Proprietario:");
            string nome_prop2 = Console.ReadLine();
            Console.WriteLine("Inserire Cognome Proprietario:");
            string cognome_prop2 = Console.ReadLine();
            Console.WriteLine("Inserire Prodotto (codice descrizione prezzo sconto):");
            string line = Console.ReadLine();
            char sep = ' ';
            string[] dati_prodotto = line.Split(sep);
            Prodotto item = new Prodotto(Int32.Parse(dati_prodotto[0]), dati_prodotto[1], Double.Parse(dati_prodotto[2]), Double.Parse(dati_prodotto[3]));

            Negozio negozio2 = new Negozio(nome2, nome_prop2, cognome_prop2, item);
            Console.WriteLine("Ho creato il negozio {0}, il cui proprietario è {1} {2}.", negozio2.Nome, negozio2.Proprietario[0], negozio2.Proprietario[1]);
            if (negozio2.Lista_prodotti == null) Console.WriteLine("Nel negozio non sono presenti prodotti.");
            else
            {
                Console.WriteLine("Nel negozio sono presenti i seguenti prodotti: ");
                foreach (var prod in negozio2.Lista_prodotti)
                {
                    Console.WriteLine("{0}", prod.Descrizione);
                }
            }

            Console.WriteLine("Test terzo costruttore.");
            Console.WriteLine("Inserire Nome Negozio:");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Inserire Nome Proprietario:");
            string nome_prop3 = Console.ReadLine();
            Console.WriteLine("Inserire Cognome Proprietario:");
            string cognome_prop3 = Console.ReadLine();
            Console.WriteLine("Inserire Prodotti (codice descrizione prezzo sconto), per terminare scrivere 'stop':");

            List<Prodotto> lista_prodotti=new List<Prodotto>();
            while (!(line = Console.ReadLine()).Equals("stop"))
            {
                string[] dati_prod = line.Split(sep);
                Prodotto product = new Prodotto(Int32.Parse(dati_prod[0]), dati_prod[1], Double.Parse(dati_prod[2]), Double.Parse(dati_prod[3]));
                lista_prodotti.Add(product);
            }
            Negozio negozio3 = new Negozio(nome3, nome_prop3, cognome_prop3, lista_prodotti);
            Console.WriteLine("Ho creato il negozio {0}, il cui proprietario è {1} {2}.", negozio3.Nome, negozio3.Proprietario[0], negozio3.Proprietario[1]);
            if (negozio3.Lista_prodotti == null) Console.WriteLine("Nel negozio non sono presenti prodotti.");
            else
            {
                Console.WriteLine("Nel negozio sono presenti i seguenti prodotti: ");
                foreach (var item2 in negozio3.Lista_prodotti)
                {
                    Console.WriteLine("{0},", item2.Descrizione);
                }
            }
        }

        private static void Test_CreazioneProdotto()
        {
            
            
            Console.WriteLine("Test primo costruttore.");
            Console.WriteLine("Inserire Codice Prodotto:");
            int codice= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Descrizione Prodotto:");
            string descrizione=Console.ReadLine();
            Console.WriteLine("Inserire Prezzo Prodotto:");
            double prezzo=Double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Sconto Prodotto:");
            double sconto = Double.Parse(Console.ReadLine());
            Prodotto item1 = new Prodotto(codice, descrizione, prezzo, sconto);
            Console.WriteLine("Ho creato il prodotto {0}, avente codice {1}, il cui prezzo è {2} euro, a cui è applicato uno sconto del {3} percento.", item1.Descrizione, item1.Codice.ToString(), item1.Prezzo.ToString(), item1.Sconto.ToString());

            
            Console.WriteLine("Test secondo costruttore.");
            Console.WriteLine("Inserire Descrizione Prodotto:");
            string descrizione2 = Console.ReadLine();
            Console.WriteLine("Inserire Prezzo Prodotto:");
            double prezzo2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Sconto Prodotto:");
            double sconto2 = Double.Parse(Console.ReadLine());
            Prodotto item2 = new Prodotto(descrizione, prezzo, sconto);
            Console.WriteLine("Ho creato il prodotto {0}, avente codice {1}, il cui prezzo è {2} euro, a cui è applicato uno sconto del {3}%.", item2.Descrizione, item2.Codice.ToString(), item2.Prezzo.ToString(), item2.Sconto.ToString());


            Console.WriteLine("Test terzo costruttore.");
            Console.WriteLine("Inserire Codice Prodotto:");
            int codice3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Inserire Descrizione Prodotto:");
            string descrizione3 = Console.ReadLine();
            Prodotto item3 = new Prodotto(codice,descrizione);
            Console.WriteLine("Ho creato il prodotto {0}, avente codice {1}, il cui prezzo è {2} euro, a cui è applicato uno sconto del {3}%.", item3.Descrizione, item3.Codice.ToString(), item3.Prezzo.ToString(), item3.Sconto.ToString());

            Console.WriteLine("Test quarto costruttore.");
            Console.WriteLine("Inserire Descrizione Prodotto:");
            string descrizione4 = Console.ReadLine();
            Prodotto item4 = new Prodotto(descrizione);
            Console.WriteLine("Ho creato il prodotto {0}, avente codice {1}, il cui prezzo è {2} euro, a cui è applicato uno sconto del {3}%.", item3.Descrizione, item3.Codice.ToString(), item3.Prezzo.ToString(), item3.Sconto.ToString());

        }
    }
}
