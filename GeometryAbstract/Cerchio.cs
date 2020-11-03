using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAbstract
{
    public class Cerchio : FiguraGeometrica
    {
        private double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }

        public override double GetArea()
        {
            return raggio * raggio * Math.PI;
        }

        public override double GetPerimetro()
        {
            return 2 * raggio * Math.PI;
        }

    }
}
