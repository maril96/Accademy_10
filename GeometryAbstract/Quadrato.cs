using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAbstract
{
    public class Quadrato : FiguraGeometrica
    {
        private double lato;

        public Quadrato(double lato)
        {
            //c'è un conflitto tra i nomi dell variabili, il this sta ad indicare l'istanza in cui ci si trova
            this.lato = lato;

        }
        public override double GetArea()
        {
            return lato * lato;
        }

        public override double GetPerimetro()
        {
            return 4 * lato;
        }


    }
}
