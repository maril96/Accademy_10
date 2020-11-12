using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Lambda
{   //è importante che il delegate sia nello stesso NameSpace, ma non nella stessa classe. In questo modo si può usare anche da altre classi dello stesso namespace
    //Questo delegate è un puntatore a metodo, che abbia segnatura int (input)->void (output)
    public delegate bool FilterInt(int i);
    public delegate bool MyDelegate(int i, string s);
    class Program
    {
        static void Main(string[] args)
        {
            /*il Main passa a FilterInts una lista di interi e un Delegate.
             *FilterInts riceve questa lista, cicla su ciascun elemento e per ognuno
             *stabilisce, applicando il filtro, se l'elemento andrà a far parte della nuova lista.
             *Il Delegate punterà ad un metodo che, dato un intero, decide se, ad esempio, è pari o dispari
             */
            List<int> lst = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };         
            //1° modo
            FilterInt filterOdd = new FilterInt(IsOdd);
            List<int> result = FilterInts(lst, filterOdd);
            //2° modo
            List<int> result2 = FilterInts(lst, IsEven);
            //nel primo caso passo davvero un delegate, nel secondo caso il passaggio è implicito: lo fa il compilatore.
            //è una facility sintattica.

            //3° modo
            //lambda-expression
            List<int> result3 = FilterInts(lst, i => (i % 2) == 1);
            /*avremmo potuto scrivere:
            List<int> result3 = FilterInts(lst, i => (i & 1) == 1);
            & è l'operatore "and bitwise", che per ogni bit mi restituisce true se sono entrambi 1 e false se uno dei due è 0 (vede 1 come true e 0 come false).
            Quindi facendo i&1 otterrò tutti 0 per le prime cifre, invece per l'ultima otterrò 1 se "i" in binario termina con 1, cioè se è dispari, mentre otterrò 0 se
            "i" termina con 0, cioè se è pari.
             */

            //l'input è sempre un delegate: nel primo caso passo davvero il delegate, nel secondo caso passo
            //il nome di un metodo, che poi viene trasformato in un delegate, nel terzo passo una lambda-expression,
            //che è sintatticamente un delegate. Essa è una funzione che ha un parametro di input (a sx della freccia) 
            //ed un parametro di output (a dx della freccia). In questo caso i parametri vengono letti del tipo richiesto da
            //FilterInt, che è ciò che prende in input la funzione FilterInts
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            //cosa a caso sotto per provare:
            MyDelegate l = (i, s) =>
            {
                if (i > s.Length) return true;
                else return false;
            };
            //questo ora è un delegate a cui è assegnato il metodo "l". Questo si può dare poi in pasto ad un metodo che prende in input un
            //parametro di tipo MyDelegate.
        }


        public static bool IsOdd(int x)
        {
            return (x % 2) == 1;
        }
        public static bool IsEven(int x)
        {
            return (x % 2) == 1;
        }
        public static List<int> FilterInts(List<int> inputList, FilterInt filter)
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList)
            {
                if (filter(item)) resultList.Add(item);
                //qui si sta invocando il metodo IsOdd
            }
            return resultList;

        }
    }
}
