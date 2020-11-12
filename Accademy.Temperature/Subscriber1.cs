using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class Subscriber1
    {
        private Termometro term;
        
        //il costruttore della classe deve prendere in ingresso un termometro, così poi potrò definire tutti i subscribers associandoli allo stesso
        public Subscriber1(Termometro term)
        {
            this.term = term;
            this.term.TemperatureTooHigh += Term_TemperatureTooHigh;
            //Ogni volta che creo il Subscriber effettuo la sottoscrizione all'evento del Termometro ad esso associato
        }

        private void Term_TemperatureTooHigh(object sender, double temperature)
        {
            Console.WriteLine("I'm Subscriber1. The temperature is {0}", temperature);
            //Questo è il metodo che voglio venga eseguito quando l'evento TemperatureTooHigh viene sollevato dal termometro associato al Subscriber
        }
    }
}
