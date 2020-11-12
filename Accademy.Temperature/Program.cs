using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accademy.Helper;

namespace Accademy.Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometro mytermometro = new Termometro();
            Subscriber1 sub1 = new Subscriber1(mytermometro);
            Subscriber2 sub2 = new Subscriber2(mytermometro);
            Subscriber3 sub3 = new Subscriber3(mytermometro);
            double simulated_temperature;
            for (int i = 0; i < 50; i++)
            {
                simulated_temperature = RandomHelper.GetRandomNumber(20, 30);
                mytermometro.SimulateTemperature(simulated_temperature);
                //qui simulo il fatto che il termometro mytermometro abbia rilevato la temperatura simulated_temperature.
            }
        }
    }
}
