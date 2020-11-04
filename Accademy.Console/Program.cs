using Accademy.Helper;
using GeometryAbstract;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Accademy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestSplit();
            // TestReadFile();
            // TestHR();
            // TestGeometry();
            // TestGeometryAbstract();       
            // TestLoops();
            // TestRand();
            // TestGeneric();

            //TestUni_001();
            //TestUni_002();
            Test_tris();

        }
        /// <summary>
        /// Creare casualmente 3 array che contengono 1 o 2 (lunghi 3), e scoprire se c'è la soluzione al 'tris'.
        /// Ora, abbiamo 9 posizioni, fare un ciclo while riempiendo le posizioni finché non vince qualcuno.
        /// Il giocatore G_A inserisce 1, e il giocatore G_B inserisce 2. Inizia un ciclo di al più 9 mosse, in cui
        /// ciascun giocatore mette il suo numero casualmente all'interno delle varie posizioni, poi il secondo mette il suo
        /// numero in una delle posizioni libere. E' possibile utilizzare una matrice int[ , ] Tris=new int [3 , 3];
        /// Nel main 'produrre' una nuova partita: ogni volta che si fa una mossa bisogna verificare se il giocatore ha vinto, se non è così si chiama il secondo a giocare.
        /// 
        /// </summary>
        private static void Test_tris()
        {
            int[,] Tris = new int[3, 3];
            initTris(Tris);
     
            bool ThereIsaWinner = false;
            bool NoMoreMoves = false;
            bool A_isWinner = false;
            bool B_isWinner = false;

            while(!ThereIsaWinner && !NoMoreMoves)
            {
                Move(1, Tris); //A è il mio 1, B è il mio 2
                A_isWinner=IsWinner(1, Tris);
                if(A_isWinner)
                {
                    ThereIsaWinner = true;
                }
                else
                {
                    if (!ThereAreMoves(Tris))
                    {
                       NoMoreMoves=true;
                    }
                    else
                    {
                        Move(2, Tris);
                        B_isWinner=IsWinner(2, Tris);
                        if (B_isWinner)
                        {
                            ThereIsaWinner=true;
                        }
                        else
                        {
                            if(!ThereAreMoves(Tris))
                                NoMoreMoves=true;
                        }
                    }
                }
            }
            
            /*Per muovere: pesco e poi calcolo i numeri modulo 9, ciclando se la casella pescata è vuota,
            Altrimenti pesco ogni volta tra un numero minore di elementi e occupo la k-esima casella vuota.
             */
            /*ThereAreMoves basta inizializzare a 0 tutto e controllare se ci sono degli zeri...*/
            /* IsWinner facciamo 3 funzioni che controllino righe, colonne e diagonali, e ogni volta che dobbiamo controllare
             * se x ha vinto, vedere dove stanno i suoi simboli e controllare solo per quelli... faremo al più 27 controlli quindi okay... */
            PrintTris(Tris);
            System.Console.WriteLine("'A is Winner' is {0}; 'B is Winner' is {1}", A_isWinner.ToString(), B_isWinner.ToString());
        
        }

        private static bool IsWinner(int v, int[,] matrix)
        {
            bool result=false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int  j = 0;  j <matrix.GetLength(1);  j++)
                {
                    if (matrix[i, j] == v)
                    {
                        result= RowControl(v,i,matrix);
                        if (result == true) break;
                        result = ColumnControl(v,j, matrix);
                        if (result == true) break;
                        if ((i+j)%2 ==0) result=DiagonalControl(v, i, j, matrix);
                        if (result == true) break;
                    }
                }
                if (result == true) break;
            }
            return result;
        }

        private static bool DiagonalControl(int v, int i, int j, int[,] matrix)
        {
            bool diagonal = false;
            bool antidiagonal = false;
            if (i == j)
            {
                diagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, k] == v) diagonal = diagonal && true;
                    else diagonal = diagonal && false;
                }
            }
            if(i+j==2)
            {
                antidiagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, matrix.GetLength(0)-1-k] == v) antidiagonal = antidiagonal && true;
                    else antidiagonal = antidiagonal && false;
                }
            }

            return (diagonal || antidiagonal);
        }

        private static bool ColumnControl(int v, int j, int[,] matrix)
        {
            bool isEqual = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool RowControl(int v, int i, int[,] matrix)
        { //restituisce true se v è vincitore lungo la riga i
            
            bool isEqual = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool ThereAreMoves(int[,] matrix)
        {
            bool result = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) 
                    { 
                        result = true;
                        break;
                    }
                }
                if (result == true) break;
            }
            return result;
        }

        private static void Move(int v, int[,] matrix)
        {
            int position = RandomHelper.GetRandomInt(0, 9);
            while (!isAvailable(position, matrix))
            {
                position = (position + 1) % 9;
            }
            matrix[position / 3, position % 3] = v;
        }
        
        private static bool isAvailable(int position, int[,] matrix)
        {
            bool result=false;
            if (matrix[position / 3, position % 3] == 0) result = true;
            return result;
        }

        private static void PrintTris(int[,] matrix)
        {
            char[,] temp = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) temp[i, j]= ' ';
                    if (matrix[i, j] == 1) temp[i, j] = 'X';
                    if (matrix[i, j] == 2) temp[i, j] = 'O';
                }
            }
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[0,0], temp[0,1], temp[0,2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[1, 0], temp[1, 1], temp[1,2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[2, 0], temp[2, 1], temp[2, 2]);

        }

        private static void initTris(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        private static void TestUni_002()
        {
            string b = "11011001";
            int converted_binary = RandomHelper.ConvertBynaryToInt(b);
            System.Console.WriteLine(converted_binary);

        }

        /// <summary>
        /// Scrivere un programma "Tutti uguali" che prevede un array di 10 numeri interi contenente valori a piacere (senza bisogno di chiederli all’utente) e stampa "tutti uguali" se i valori
        /// dell’array sono tutti uguali, oppure stampa "non tutti uguali" altrimenti. (Il programma deve essere
        /// scritto facendo finta di non sapere quali siano i valori inseriti nell’array) Per riempire l'array utilizzare la classe Helper in due casi:
        /// il primo restituisce valori casuali, il secondo restituisce valori uguali.
        /// </summary>
        private static void TestUni_001()
        {
            int[] myArray1 = new int[10];
            int[] myArray2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                myArray1[i] = RandomHelper.GetSameInt(2);
                myArray2[i] = RandomHelper.GetRandomInt(1, 100);
            }
            ElementsCompare(myArray1);
            ElementsCompare(myArray2);

            bool areDifferent = AllDifferent(myArray2);
            System.Console.WriteLine("'The elements are all different' is {0}", areDifferent.ToString());

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns>returns true if all the elements of a given array are different from each other</returns>
        private static bool AllDifferent(int[] array)
        {
            bool result = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        result = false;
                        break;
                    }

                }
                if (result == false) break;
            }

            return result;
        }

        private static void ElementsCompare(int[] Array)
        {
            int comp;
            comp = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (comp != Array[i])
                {
                    System.Console.WriteLine("Non tutti uguali");
                    break;
                }
                if (i == Array.Length - 1) System.Console.WriteLine("Tutti uguali");
            }

        }

        private static void TestGeneric()
        {
            List<int> lst_int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            if (lst_int.Contains(3))
                System.Console.WriteLine("3 is in List");

            List<Persona> lst_persona = new List<Persona>();
            Persona mario = new Persona("Mario", "Rossi");
            Persona maria = new Persona("Maria", "Bianchi");
            Persona gianni = new Persona("Gianni", "Giallo");

            lst_persona.Add(mario);
            lst_persona.Add(maria);
            lst_persona.Add(gianni);

            Persona p = new Persona("Mario", "Rossi");

            if (lst_persona.Contains(p))
                System.Console.WriteLine("Persona is in List");
            else
                System.Console.WriteLine("Persona is NOT in List");

            System.Console.WriteLine(p.Equals(mario));
            System.Console.WriteLine(p.GetHashCode());
            System.Console.WriteLine(mario.GetHashCode());

            Persona sosia_mario = mario;
            System.Console.WriteLine(sosia_mario.GetHashCode()); //è uguale a quello di mario
                                                                 //vado a modificare persona in modo che quelli che hanno lo stesso nome e cognome abbiano lo stesso HashCode


        }

        private static void TestRand()
        {
            String dir = @"C:\Users\marilena.pandolfi\Documents\Microsoft Accademy";
            String name = "random_test.txt";
            String path = System.IO.Path.Combine(dir, name);


            System.IO.StreamWriter NewFile = new System.IO.StreamWriter(path);
            String daScrivere;
            double numero;

            int a = 0;
            int b = 5;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    numero = Helper.RandomHelper.GetRandomNumber(a, b);


                }

                catch (RandomArgumentsException excp)
                {

                    System.Console.WriteLine(excp.Message);
                    break;
                }
                finally
                {
                    //qui si mettono le cose che vanno eseguite qualunque cosa succeda in try/catch
                }

                daScrivere = Convert.ToString(numero);
                NewFile.WriteLine(daScrivere);

            }
            NewFile.Close();


            System.IO.StreamReader File = new System.IO.StreamReader(path);

            String line;
            while ((line = File.ReadLine()) != null)
            {
                double randomNum = 0;
                try
                {
                    randomNum = Double.Parse(line);
                }
                catch (FormatException excp)
                {
                    System.Console.WriteLine(excp.Message);
                    //così facendo viene mostrato il messaggio e l'esecuzione va avanti, altrimenti si sarebbe fermata.
                    //Si può però anche fargli fare qualcosa di diverso.
                }

                System.Console.WriteLine(randomNum + 1000);
            }
            File.Close();
            System.Console.ReadLine(); //questo serve a bloccare l'esecuzione ad un certo punto
            //e l'esecuzione riprende quando premiamo qualcosa, questo a livello di debug. Mentre se facciamo
            //davvero partire il programma questo si fa in automatico.
        }

        private static void TestLoops()
        {
            //declare string s
            //transform s in char array
            //use 'for' loop to invert array chars
            //transform the new array in string
            //Console.Writeline the new string

            String s = "qwertyuiop";

            char[] ca_s = s.ToCharArray();
            int len = ca_s.Length;
            char[] inv_ca = new char[len];

            String inv_s = String.Empty;

            for (int i = 0; i < len; i++)
            {
                inv_ca[i] = ca_s[len - i - 1];
                inv_s = inv_s + inv_ca[i];

            }

            System.Console.WriteLine(inv_s);

            //con le liste:
            //dichiarare una lista di caratteri
            //ciclo for per inserire i caratteri ABCDEFGHIJ
            //dichiarare un array di char, ciclare sulla lista e inserire in modo invertito nell'array
            //trasformare l'array in una lista.
            //ciclo foreach sulla seconda lista per stamparne i caratteri.

            List<char> charList = new List<char>();
            //charList.Add() aggiunge un carattere
            //ciclare su una lista usa il foreach e cicla su ogni elemento della collection
            Char daInserire;
            for (int i = 65; i < 75; i++)
            {
                daInserire = Convert.ToChar(i);
                charList.Add(daInserire);
            }

            int length = charList.Count;
            Char[] charArr = new Char[length];
            int j = length - 1;
            foreach (char c in charList)
            {
                charArr[j] = c;
                j--;
            }
            List<char> inv_charList = charArr.ToList();
            foreach (char c in inv_charList)
            {
                System.Console.WriteLine(c);
            }

        }

        private static void TestGeometryAbstract()
        {
            GeometryAbstract.Quadrato q1 = new GeometryAbstract.Quadrato(11.009);
            GeometryAbstract.Cerchio c1 = new GeometryAbstract.Cerchio(9.25);

            PrintFiguraAbstract(q1);
            PrintFiguraAbstract(c1);
        }

        private static void PrintFiguraAbstract(GeometryAbstract.FiguraGeometrica f)
        {
            string s = f.GetDescription();
            System.Console.WriteLine(s);
        }

        private static void TestGeometry()
        {
            Accademy.Geometry.Quadrato q1 = new Accademy.Geometry.Quadrato(12.98);
            Accademy.Geometry.Cerchio c1 = new Accademy.Geometry.Cerchio(11.75);
            //System.Console.WriteLine("Quadrato: Area {0}, Perimetro {1}", q1.getArea(), q1.getPerimetro());
            //System.Console.WriteLine("Cerchio: Area {0}, Circonferenza {1}", c1.getArea(), c1.getPerimetro());

            PrintFigura(q1);
            PrintFigura(c1);

        }

        private static void PrintFigura(Geometry.IFiguraGeometrica f)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", f.getArea(), f.getPerimetro());
        }
        /* Uso l'interfaccia alla riga precedente, per evitare di scrivere più volte il codice come sotto.
         * private static void PrintCerchio(Cerchio c1)
           {
               System.Console.WriteLine("Cerchio: Area {0}, Circonferenza {1}", c1.getArea(), c1.getPerimetro());
           }

           private static void PrintQuadrato(Quadrato q1)
           {
               System.Console.WriteLine("Quadrato: Area {0}, Perimetro {1}", q1.getArea(), q1.getPerimetro());
           }*/

        private static void TestHR()
        {
            //prima di istanziare una persona, devo aggiungere il riferimento a Human Resources: clicco col dx su
            //Accademy.Console, e aggiungo il riferimento al progetto HumanResources.
            Persona mario = new Persona("Mario", "Rossi");

            mario.SetIndirizzo("Via Roma,1");

            System.Console.WriteLine(mario.ToString());
            //il toString implementato dall'Object mi stampa il tipo della classe a cui è applicato, per quello si fa l'override se si vuole fare altro.

            Impiegato imp = new Impiegato("Matilde", "Bianchi", 33);
            imp.SetIndirizzo("Via Lourdes,32");
            //tutte le classi create ereditano dalla classe Object i metodi ToString, Equals, GetType, GetHashCode.
            //oppure una certa classe può ereditare da un'altra classe (impiegato da persona), che deriva a sua volta da Object. 
            //Alla fine tutte le classi ereditano, direttamente o indirettamente, da Object.
            //Da una classe possono ereditare più classi.
            //Una classe non può ereditare da più classi, se non in modo indiretto.
            //i modificatori di accesso (public/private), danno la possibilità o meno di modificare o visualizzare delle proprietà/metodi.

            //System.Console.WriteLine("Istanza mario: {0}, {1}", mario.Nome, mario.Cognome);
            System.Console.ReadLine();
        }

        private static void TestSplit()
        {
            string s = "25.67\t998.41";
            char[] chararray = new char[1];
            //anche in C# gli array sono 0-based. Gli indici vanno da 0 in poi.
            //quando non conosco la lunghezza uso le liste, che vengono gestite dinamicamente.
            string[] stringarray = new string[2];
            //i char si inseriscono tra apici, le stringhe tra doppi apici.
            chararray[0] = '\t';
            String[] resultArray = s.Split(chararray);
            //applico alla stringa s il metodo split, che prende in input un array di caratteri.
            //ora in resultArray ci sono le stringhe "25.67" e "998.41", che vorremmo trasformare in numeri

            //ascii 8 bit. unicode 16 bit

            String temperature = resultArray[0];
            String pressure = resultArray[1];

            float temp_float = float.Parse(temperature);
            float press_float = float.Parse(pressure);
            System.Console.WriteLine("Temperatura {0} Pressione {1}", temp_float, press_float);
            System.Console.ReadLine();
        }

        private static void TestReadFile()
        {

            //leggiamo un file di testo, poi stampiamo/modifichiamo/facciamo un database
            //string[] è un array di stringhe

            String dir = @"C:\Users\marilena.pandolfi\Documents\Microsoft Accademy";
            //memorizzo il percorso del file
            //il comando \r\n in una stringa fa sì che si vada a capo
            //il comando \t è un tabulatore, fa andare avanti di 4. Per evitare tutto questo, mettendo
            //una @ davanti alle virgolette della stringa si fa in modo che non vengano letti i caratteri di escape
            String filename = "pressione.txt";
            String path = dir + @"\" + filename;
            //concateno le stringhe con +
            //voglio leggere il file. Devo cercare la classe che lo fa.

            //scriviamo due file di testo, uno per la pressione e uno per la temperatura
            string out_temp = "temperature.txt";
            string out_press = "pressure.txt";
            System.IO.StreamWriter tempOutputFile = new System.IO.StreamWriter(System.IO.Path.Combine(dir, out_temp));
            System.IO.StreamWriter pressOutputFile = new System.IO.StreamWriter(System.IO.Path.Combine(dir, out_press));

            int counter = 0;
            string line;
            //non importa scrivere String o string, quando si compila tutto è un oggetto: non ci sono le variabili primitive in C#
            //infatti passandoci su con il mouse indica la stessa cosa
            //read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            //a sx si dichiara una variabile oggetto (tutte le variabili lo sono!), a dx se ne crea un'istanza.
            //la classe StreamReader è in un assembly (mscorlib) che è già referenziato all'interno del progetto, lo vedo se clicco a dx
            //su add reference e provo ad aggiungerlo.

            // Se voglio leggere un altro file dovrei creare un altra istanza di streamreader ed associarla ad un altro file (passandole il percorso dell'altro file).

            //con la prec linea di comando ho dichiarato uno stream, che è un oggetto in grado di poter leggere un flusso di byte a partire da un percorso di rete o da una scheda di rete
            //dopo aver creato uno stream si comincia a leggere
            float max_float = float.MaxValue;
            float min_float = float.MinValue;

            float min_temp = max_float;
            float max_temp = min_float;

            float min_press = max_float;
            float max_press = min_float;

            float sum_temp = 0;
            float sum_press = 0;
            //assegno questi valori (MaxValue e MinValue sono delle proprietà di float, che rapp delle costanti, i valori min e max che si possono avere come float)
            //poi vado a rimpiazzarli con i max e min correnti man mano che leggo il file.

            char[] chararray = new char[1];
            chararray[0] = '\t';

            while ((line = file.ReadLine()) != null)
            {
                //si vogliono cercare max e min. Ma ho delle stringhe. Cerco in string un metodo che possa fare ciò che voglio, cioè estrapolare dei numeri dalle stringhe.
                //Trovo split, che però prende in ingresso un array di char, dove devo inserire il mio separatore, che è il tab \t.
                // System.Console.WriteLine(line);
                if (counter > 0)
                {
                    String[] resultArray = line.Split(chararray);

                    //qui scrivo il file temperatura
                    tempOutputFile.WriteLine(resultArray[0]);
                    pressOutputFile.WriteLine(resultArray[1]);

                    float temp_float = float.Parse(resultArray[0]);
                    float press_float = float.Parse(resultArray[1]);
                    sum_temp += temp_float; //analogo a sum_temp=sum_temp+temp_float;
                    sum_press += press_float;

                    if (temp_float > max_temp)
                        max_temp = temp_float;

                    if (temp_float < min_temp)
                        min_temp = temp_float;

                    if (press_float > max_press)
                        max_press = press_float;

                    if (press_float < min_press)
                        min_press = press_float;

                }

                counter++;
            }
            /* ciclo while: tra tonde c'è la guardia, che dice quando fermarsi: questa è un'espressione booleana. Se la guardia è vera
             * si eseguono le istruzioni tra graffe; se è falsa si esce dal ciclo.
             * Un booleano è un risultato che può essere T o F. In questo caso viene confrontato il risultato di una lettura con la parola chiave 'null'.
             * Viene prima eseguito il metodo Readline. file è un'istanza di streamreader, ed è agganciato con il path del file che si vuole leggere.
             * Per utilizzare una classe bisogna analizzarne i metodi e vedere cosa fanno. Readline legge riga per riga e restituisce una stringa, che noi salviamo in line.
             * Ad ogni iterazione line contiene una stringa che è la riga corrente. Se line non è null, la riga viene stampata e si incrementa il counter.
             * Una volta letta l'ultima riga si esce dal ciclo.
             */


            file.Close();
            tempOutputFile.Close();
            pressOutputFile.Close();
            //chiudo lo stream di byte: il file viene chiuso.

            float media_temp = sum_temp / (counter - 1);
            float media_press = sum_press / (counter - 1);

            System.Console.WriteLine(media_temp);
            System.Console.WriteLine(media_press);

            System.Console.WriteLine("There were {0} lines.", counter);
            //al posto di {0} si va a scrivere counter. Se si volesse inserire altro si continuerebbe con {1}, eccetera.
            System.Console.WriteLine("Min Temperature {0}, Max Temperature {1},\r\nMin Pressure {2}, Max Pressure {3}", min_temp, max_temp, min_press, max_press);
            System.Console.ReadLine();
        }
    }
}


/*se metto un breakpoint all'inizio del ciclo, si ferma dopo aver letto la prima riga, su cui legge "t\tp", in cui \t è la tabulazione
 *se faccio F10 va avanti un passo alla volta. Posso poi mettere un altro breakpoint sotto e fare 'continue', così si prosegue l'esecuzione fino a quest'ultimo.
 * Se seleziono tutta una parte, clicco col destro, poi sulla lampadina posso creare un metodo che contiene tutto quel testo, e me lo scrive sotto al main, e me lo chiama nel main
 *al posto del testo che avevo selezionato.
 * Se provo a chiamare un metodo che non ho ancora definito, clicco col destro, e la lampadina mi dirà che posso creare quel metodo.
 */


/*se eseguo più volte i file che scrive vengono di volta in volta sovrascritti di default*/