using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    //mi serve definire il Delegate nella stessa classe: l'evento dev'essere dello stesso tipo
    public delegate void TemperatureTooHighEventHandler(Object sender, double temperature);
    public class Termometro
    {
        //questo e' il mio notifier

        //deve esporre l'evento
        public event TemperatureTooHighEventHandler TemperatureTooHigh;

        //devo simulare il fatto che l'evento venga sollevato con una funzione
        //ogni volta che l'evento viene sollevato devo scorrere la lista dei subscriber ed eseguire i loro metodi

        public void SimulateTemperature(double temperature)
        {
            //Questa funzione simula il fatto che il termometro abbia misurato una certa temperatura: se questa è maggiore di 25 viene sollevato l'evento TemperatureTooHigh
            if (temperature > 25)
            {
                //se la temperatura è maggiore di 25 sollevo l'evento.

                if (TemperatureTooHigh != null)
                {
                    foreach (Delegate item in TemperatureTooHigh.GetInvocationList().ToList())
                    {
                        TemperatureTooHighEventHandler del = (TemperatureTooHighEventHandler)item;
                        //eseguo il metodo di ogni delegate
                        del(this, temperature);

                    }
                }
            }
        }
            
            
    }
}
