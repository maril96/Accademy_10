using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Cerchio : IFiguraGeometrica
    {
        private double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }

        public double getArea()
        {
            return raggio * raggio * Math.PI;
        }

        public double getPerimetro()
        {
            return 2 * raggio * Math.PI;
        }


    }
}
