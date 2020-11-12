using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class Subscriber2
    {
        private Termometro term;
        public Subscriber2(Termometro term)
        {
            this.term = term;
            this.term.TemperatureTooHigh += Term_TemperatureTooHigh;

        }

        private void Term_TemperatureTooHigh(object sender, double temperature)
        {
            Console.WriteLine("I'm Subscriber2. The temperature is {0}", temperature);
        }
    }
}
