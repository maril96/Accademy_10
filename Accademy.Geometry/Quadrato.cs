using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Quadrato : IFiguraGeometrica
    {
        private double lato;

        public Quadrato(double lato)
        {
            //c'è un conflitto tra i nomi dell variabili, il this sta ad indicare l'istanza in cui ci si trova
            this.lato = lato;
            
        }

        public double getArea()
        {
            return lato * lato;
        }

        public double getPerimetro()
        {
            return 4 * lato;
        }
    }
}
