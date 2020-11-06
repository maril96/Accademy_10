using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomHelper
    {
        /// <summary>
        /// Get a random value in a range
        /// </summary>
        /// <param name="min">min range value</param>
        /// <param name="max">max range value</param>
        /// <exception cref="Accademy.Helper.RandomArgumentsException">Thrown when min value is greater than max value</exception>
        /// <returns>random double in a range</returns>
        public static double GetRandomNumber (int min, int max)
        {
            Guid newGuid = Guid.NewGuid(); //stringa casuale
            int hash = newGuid.GetHashCode(); //ne faccio l'hash per ottenerne un intero casuale
            int seed = hash;
            System.Random RandClass = new System.Random(seed);
            double randNum = RandClass.NextDouble();

            double result =0;

            if (min>max)
            {
                throw new RandomArgumentsException();
            //sollevo l'eccezione che ho creato
            }
            else
            {
               
                result = randNum * (max - min) + min;

            }
            

            return result;
        }
        //i commenti con i 3 slash si riferiscono a quanto c'è sotto, ad esempio al metodo o alla classe/proprietà subito sotto. é in formato xml.
        public static int GetRandomInt(int min, int max)
        {
            Guid newGuid = Guid.NewGuid(); //stringa casuale
            int hash = newGuid.GetHashCode(); //ne faccio l'hash per ottenerne un intero casuale
            int seed = hash;
            System.Random RandClass = new System.Random(seed);
            int result;

            if (min > max)
            {
                throw new RandomArgumentsException();
                //sollevo l'eccezione che ho creato
            }
            else
            {
                result = RandClass.Next(min, max);
            }

            return result;
        }
        public static int GetSameInt(int num)
        {
            return num;
        }

        public static int ConvertBynaryToInt(string binaryString)
        {
            //verificare che la stringa contenga solo caratteri 0 e 1, altrimenti restituire -1.
            char[] binaryCharArray = binaryString.ToCharArray();

            int[] binaryArray = new int[binaryCharArray.Length];
            
            for (int i = 0; i < binaryCharArray.Length; i++)
            {

                /* lui ha fatto così:
                 *  error=false;
                 *  for(int i=binaryString.Length-1; i>=0; i--)
                 *  if(binaryString[i]=='0' || binaryString[i]=='1'){
                 *  { string bit_string=binaryString.Substring(i,1);
                 *  //Qui substring è proprio la stringa "1" o "0", per cui il Parsing ad intero non restituisce il codice ASCII ma proprio 0 o 1
                 *  binary_Array[i]=Int32.Parse(bit_string);}
                 *  else{ error=true;} 
                  */

               binaryArray[i]= Convert.ToInt32(Char.GetNumericValue(binaryCharArray[binaryCharArray.Length -i-1]));
                
                if (binaryArray[i] != 0 && binaryArray[i] != 1) return -1;
            }
            double result =0;
           
            for (int  i=0;i< binaryArray.Length; i++)
            {
                result += (binaryArray[i] * Math.Pow(2,i));
            }

            return Convert.ToInt32(result) ;

        }
        public static string GetNumConto(int numChars)
        {
            string numconto;

            
            if (numChars <= 36)
            {
                Guid newGuid = Guid.NewGuid();
                string s_newGuid = newGuid.ToString();
                numconto = s_newGuid.Substring(0, numChars);
            }
            else numconto = "";
                return numconto;
        }
    }
}
