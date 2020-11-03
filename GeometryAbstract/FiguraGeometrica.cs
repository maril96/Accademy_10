using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAbstract
{
    public abstract class FiguraGeometrica
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();
    
        public string GetDescription()
        {
            Type t = this.GetType(); //mi dice il tipo dell'oggetto...cioè la classe di cui è istanza
            string myType = t.ToString();
            string description = "I'm a "+ myType + "with Area: " + GetArea() + "Perimetro: " + GetPerimetro();
            return description;
        }
    }
}
