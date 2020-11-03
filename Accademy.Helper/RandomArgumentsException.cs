using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomArgumentsException : Exception
    {
        //public override string Message => "Min range is greater than max range";
        public override string Message
        {
            get
            {
                return "Min range is greater than max range";
            }
            //questo è il get della proprietà Message
        }
    }
}
